using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.APIs;
using UWOpenDataLib.JsonModels.Common;
using UWOpenDataLib.JsonModels.Events;
using UWOpenDataLib.JsonModels.Terms;
using UWOpenDataLib.JsonModels.Weather;
using UWOpenDataLib.Utilities;

namespace UWOpenDataLib.Services
{
    public class APIManager
    {
        #region Constructor

        private static APIManager _instance;
        public static APIManager Instance
        {
            get { return _instance ?? (_instance = new APIManager()); }
        }

        private readonly DataService _dataService;

        private APIManager()
        {
            _dataService = new DataService();
        }

        #endregion

        #region Public Methods


        public async Task<Response<APIsMethodsRoot>> GetApisMethodsData(CancellationToken cancellationToken)
        {
            return await _dataService.GetApisMethodsDataTaskAsync(Constants.ApiMethodsUrl, cancellationToken);
        }
        public async Task<Response<APIsServicesRoot>> GetApisServicesData(CancellationToken cancellationToken)
        {
            return await _dataService.GetApisServicesDataTaskAsync(Constants.ApiServicesUrl, cancellationToken);
        }

        public async Task<Response<EventsHolidaysRoot>> GetEventsHolidayData(CancellationToken cancellationToken)
        {
            return await _dataService.GetEventsHolidayDataTaskAsync(Constants.EventsHolidaysUrl, cancellationToken);
        }


        public async Task<Response<TermsListRoot>> GetTermsListData(CancellationToken cancellationToken)
        {
            return await _dataService.GetTermsListDataTaskAsync(Constants.TermsListUrl, cancellationToken);
        }

        public async Task<Response<TermsExamScheduleRoot>> GetTermsExamScheduleData(String term, CancellationToken cancellationToken)
        {
            var url = String.Format(Constants.TermsExamScheduleUrl, term);
            return await _dataService.GetTermsExamScheduleDataTaskAsync(url, cancellationToken);
        }
        public async Task<Response<TermsSubjectScheduleRoot>> GetTermsSubjectScheduleData(String term, String subject, CancellationToken cancellationToken)
        {
            var url = String.Format(Constants.TermsSubjectScheduleUrl, term, subject);
            return await _dataService.GetTermsSubjectScheduleDataTaskAsync(url, cancellationToken);
        }

        public async Task<Response<TermsCourseScheduleRoot>> GetTermsCourseScheduleData(String term, String subject, String catalogNumber, CancellationToken cancellationToken)
        {
            var url = String.Format(Constants.TermsCourseScheduleUrl, term, subject, catalogNumber);
            return await _dataService.GetTermsCourseScheduleDataTaskAsync(url, cancellationToken);
        }

        public async Task<Response<WeatherRoot>> GetWeatherData(CancellationToken cancellationToken)
        {
            return await _dataService.GetWeatherDataTaskAsync(Constants.WeatherUrl, cancellationToken);
        }

        #endregion

        #region Private Implementation Details

        private class DataService
        {
            private JsonUtil _jsonUtil;
            private JsonUtil JsonUtil
            {
                get { return _jsonUtil ?? (_jsonUtil = new JsonUtil()); }
            }

            private async Task<Response<T>> GetDataTaskAsync<T>(string url, CancellationToken cancellationToken)
            {
                Debug.WriteLine(url);
                if (cancellationToken.IsCancellationRequested)
                {
                    Debug.WriteLine("Cancelled before task started");
                    cancellationToken.ThrowIfCancellationRequested();
                }

                try
                {
                    var jsonResponse = await JsonUtil.GetJsonDataResponseAsync<T>(url, cancellationToken);
                    return new Response<T>()
                    {
                        Data = jsonResponse
                    };
                }
                catch (OperationCanceledException operationCanceledException)
                {
                    return new Response<T>()
                    {
                        Data = default(T),
                        Exception = operationCanceledException
                    };
                }
                catch
                {
                    return new Response<T>()
                    {
                        Exception = new Exception()
                    };
                }
            }

            public async Task<Response<APIsMethodsRoot>> GetApisMethodsDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<APIsMethodsRoot>(url, cancellationToken);
            }

            public async Task<Response<APIsServicesRoot>> GetApisServicesDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<APIsServicesRoot>(url, cancellationToken);
            }

            public async Task<Response<WeatherRoot>> GetWeatherDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<WeatherRoot>(url, cancellationToken);
            }

            public async Task<Response<EventsHolidaysRoot>> GetEventsHolidayDataTaskAsync(string url,
                CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<EventsHolidaysRoot>(url, cancellationToken);
            }

            public async Task<Response<TermsListRoot>> GetTermsListDataTaskAsync(string url,
                CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<TermsListRoot>(url, cancellationToken);
            }

            public async Task<Response<TermsExamScheduleRoot>> GetTermsExamScheduleDataTaskAsync(string url,
                CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<TermsExamScheduleRoot>(url, cancellationToken);
            }

            public async Task<Response<TermsCourseScheduleRoot>> GetTermsCourseScheduleDataTaskAsync(string url,
                CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<TermsCourseScheduleRoot>(url, cancellationToken);
            }

            public async Task<Response<TermsSubjectScheduleRoot>> GetTermsSubjectScheduleDataTaskAsync(string url,
                CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<TermsSubjectScheduleRoot>(url, cancellationToken);
            }
        }

        #endregion
    }

    public class Response<T>
    {
        public T Data { get; set; }
        public Exception Exception { get; set; }

        public Boolean HasError()
        {
            if (Exception != null)
            {
                return true;
            }

            var root = Data as Root;
            if (root != null && root.meta != null && root.meta.status == 200)
            {
                return false;
            }

            return true;
        }
    }
}
