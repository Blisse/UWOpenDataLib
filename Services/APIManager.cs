using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.Common;
using UWOpenDataLib.JsonModels.Events;
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

        public async Task<Response<WeatherRoot>> GetWeatherData()
        {
            return await GetWeatherData(CancellationToken.None);
        }

        public async Task<Response<WeatherRoot>> GetWeatherData(CancellationToken cancellationToken)
        {
            return await _dataService.GetWeatherDataTaskAsync(Constants.WeatherBaseUrl, cancellationToken);
        }

        public async Task<Response<EventsHolidayRoot>> GetEventsHolidayData()
        {
            return await GetEventsHolidayData(CancellationToken.None);
        }

        public async Task<Response<EventsHolidayRoot>> GetEventsHolidayData(CancellationToken cancellationToken)
        {
            return await _dataService.GetEventsHolidayDataTaskAsync(Constants.EventsHolidaysUrl, cancellationToken);
        }

        #endregion

        #region Private Implementations

        private class DataService
        {
            private JsonUtil _jsonUtil;
            private JsonUtil JsonUtil
            {
                get { return _jsonUtil ?? (_jsonUtil = new JsonUtil()); }
            }

            private async Task<Response<T>> GetDataTaskAsync<T>(string url, CancellationToken cancellationToken)
            {
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

            public async Task<Response<WeatherRoot>> GetWeatherDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<WeatherRoot>(url, cancellationToken);
            }

            public async Task<Response<EventsHolidayRoot>> GetEventsHolidayDataTaskAsync(string url,
                CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<EventsHolidayRoot>(url, cancellationToken);
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
