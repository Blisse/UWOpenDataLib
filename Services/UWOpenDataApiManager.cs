using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UWOpenDataLib.JsonModels.APIs;
using UWOpenDataLib.JsonModels.Common;
using UWOpenDataLib.JsonModels.Courses;
using UWOpenDataLib.JsonModels.Events;
using UWOpenDataLib.JsonModels.FoodServices;
using UWOpenDataLib.JsonModels.Terms;
using UWOpenDataLib.JsonModels.Weather;
using UWOpenDataLib.Utilities;

namespace UWOpenDataLib.Services
{
    public class UWOpenDataApiManager
    {
        #region Constructor
        
        private readonly DataService _dataService;

        public UWOpenDataApiManager()
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

        public async Task<Response<FoodServicesDietsRoot>> GetFoodServicesDietsData(CancellationToken cancellationToken)
        {
            return await _dataService.GetFoodServicesDietsDataTaskAsync(Constants.FoodServicesDietsUrl, cancellationToken);
        }
        public async Task<Response<FoodServicesOutletsRoot>> GetFoodServicesOutletsData(CancellationToken cancellationToken)
        {
            return await _dataService.GetFoodServicesOutletsDataTaskAsync(Constants.FoodServicesOutletsUrl, cancellationToken);
        }
        public async Task<Response<FoodServicesLocationsRoot>> GetFoodServicesLocationsData(CancellationToken cancellationToken)
        {
            return await _dataService.GetFoodServicesLocationsDataTaskAsync(Constants.FoodServicesDietsUrl, cancellationToken);
        }
        public async Task<Response<FoodServicesWatCardRoot>> GetFoodServicesWatCardData(CancellationToken cancellationToken)
        {
            return await _dataService.GetFoodServicesWatCardDataTaskAsync(Constants.FoodServicesDietsUrl, cancellationToken);
        }
        public async Task<Response<FoodServicesMenuRoot>> GetFoodServicesMenuData(string year, string week, CancellationToken cancellationToken)
        {
            var url = String.Format(Constants.FoodServicesMenuUrl, year, week);
            return await _dataService.GetFoodServicesMenuDataTaskAsync(url, cancellationToken);
        }
        public async Task<Response<FoodServicesWeeksNotesRoot>> GetFoodServicesNotesData(string year, string week, CancellationToken cancellationToken)
        {
            var url = String.Format(Constants.FoodServicesNotesUrl, year, week);
            return await _dataService.GetFoodServicesNotesDataTaskAsync(url, cancellationToken);
        }
        public async Task<Response<FoodServicesAnnouncementsRoot>> GetFoodServicesAnnouncementsData(string year, string week, CancellationToken cancellationToken)
        {
            var url = String.Format(Constants.FoodServicesAnnouncementsUrl, year, week);
            return await _dataService.GetFoodServicesAnnouncementsDataTaskAsync(url, cancellationToken);
        }
        public async Task<Response<FoodServicesProductDetailsRoot>> GetFoodServicesProductsDataByProductId(string productId, CancellationToken cancellationToken)
        {
            var url = String.Format(Constants.FoodServicesProductsUrl, productId);
            return await _dataService.GetFoodServicesProductsDataTaskAsync(url, cancellationToken);
        }

        public async Task<Response<CoursesSubjectRoot>> GetCoursesSubjectDataBySubject(String subject, CancellationToken cancellationToken)
        {
            var url = String.Format(Constants.CoursesBaseUrl, subject);
            return await _dataService.GetCoursesSubjectDataTaskAsync(url, cancellationToken);
        }
        public async Task<Response<CoursesIdRoot>> GetCoursesDataByCourseId(String courseId, CancellationToken cancellationToken)
        {
            var url = String.Format(Constants.CoursesBaseUrl, courseId);
            return await _dataService.GetCoursesIdDataTaskAsync(url, cancellationToken);
        }
        public async Task<Response<CoursesScheduleRoot>> GetCoursesScheduleDataByClassNumber(String classNumber, CancellationToken cancellationToken)
        {
            var url = String.Format(Constants.CoursesScheduleByClassNumberUrl, classNumber);
            return await _dataService.GetCoursesScheduleDataTaskAsync(url, cancellationToken);
        }
        public async Task<Response<CoursesIdRoot>> GetCoursesDataByCatalogNumber(String subject, String catalogNumber, CancellationToken cancellationToken)
        {
            var url = String.Format(Constants.CoursesInfoUrl, subject, catalogNumber);
            return await _dataService.GetCoursesIdDataTaskAsync(url, cancellationToken);
        }
        public async Task<Response<CoursesScheduleRoot>> GetCoursesScheduleDataByCatalogNumber(String subject, String catalogNumber, CancellationToken cancellationToken)
        {
            var url = String.Format(Constants.CoursesScheduleUrl, subject, catalogNumber);
            return await _dataService.GetCoursesScheduleDataTaskAsync(url, cancellationToken);
        }
        public async Task<Response<CoursesPrerequisitesRoot>> GetCoursesPrerequisitesDataByCatalogNumber(String subject, String catalogNumber, CancellationToken cancellationToken)
        {
            var url = String.Format(Constants.CoursesPrerequisitesUrl, subject, catalogNumber);
            return await _dataService.GetCoursesPrerequisitesDataTaskAsync(url, cancellationToken);
        }
        public async Task<Response<CoursesExamScheduleRoot>> GetCoursesExamScheduleDataByCatalogNumber(String subject, String catalogNumber, CancellationToken cancellationToken)
        {
            var url = String.Format(Constants.CoursesExamScheduleUrl, subject, catalogNumber);
            return await _dataService.GetCoursesExamScheduleDataTaskAsync(url, cancellationToken);
        }

        public async Task<Response<TermsListRoot>> GetTermsListData(CancellationToken cancellationToken)
        {
            return await _dataService.GetTermsListDataTaskAsync(Constants.TermsListUrl, cancellationToken);
        }
        public async Task<Response<TermsExamScheduleRoot>> GetTermsExamScheduleDataByTerm(String term, CancellationToken cancellationToken)
        {
            var url = String.Format(Constants.TermsExamScheduleUrl, term);
            return await _dataService.GetTermsExamScheduleDataTaskAsync(url, cancellationToken);
        }
        public async Task<Response<TermsSubjectScheduleRoot>> GetTermsSubjectScheduleDataBySubject(String term, String subject, CancellationToken cancellationToken)
        {
            var url = String.Format(Constants.TermsSubjectScheduleUrl, term, subject);
            return await _dataService.GetTermsSubjectScheduleDataTaskAsync(url, cancellationToken);
        }
        public async Task<Response<TermsCourseScheduleRoot>> GetTermsCourseScheduleDataByCatalogNumber(String term, String subject, String catalogNumber, CancellationToken cancellationToken)
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
                        Data = jsonResponse,
                        TimeStamp = DateTime.UtcNow
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
            public async Task<Response<EventsHolidaysRoot>> GetEventsHolidayDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<EventsHolidaysRoot>(url, cancellationToken);
            }

            public async Task<Response<CoursesIdRoot>> GetCoursesIdDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<CoursesIdRoot>(url, cancellationToken);
            }
            public async Task<Response<CoursesPrerequisitesRoot>> GetCoursesPrerequisitesDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<CoursesPrerequisitesRoot>(url, cancellationToken);
            }
            public async Task<Response<CoursesScheduleRoot>> GetCoursesScheduleDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<CoursesScheduleRoot>(url, cancellationToken);
            }
            public async Task<Response<CoursesSubjectRoot>> GetCoursesSubjectDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<CoursesSubjectRoot>(url, cancellationToken);
            }
            public async Task<Response<CoursesExamScheduleRoot>> GetCoursesExamScheduleDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<CoursesExamScheduleRoot>(url, cancellationToken);
            }

            public async Task<Response<FoodServicesMenuRoot>> GetFoodServicesMenuDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<FoodServicesMenuRoot>(url, cancellationToken);
            }
            public async Task<Response<FoodServicesWeeksNotesRoot>> GetFoodServicesNotesDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<FoodServicesWeeksNotesRoot>(url, cancellationToken);
            }
            public async Task<Response<FoodServicesDietsRoot>> GetFoodServicesDietsDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<FoodServicesDietsRoot>(url, cancellationToken);
            }
            public async Task<Response<FoodServicesOutletsRoot>> GetFoodServicesOutletsDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<FoodServicesOutletsRoot>(url, cancellationToken);
            }
            public async Task<Response<FoodServicesLocationsRoot>> GetFoodServicesLocationsDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<FoodServicesLocationsRoot>(url, cancellationToken);
            }
            public async Task<Response<FoodServicesWatCardRoot>> GetFoodServicesWatCardDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<FoodServicesWatCardRoot>(url, cancellationToken);
            }
            public async Task<Response<FoodServicesAnnouncementsRoot>> GetFoodServicesAnnouncementsDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<FoodServicesAnnouncementsRoot>(url, cancellationToken);
            }
            public async Task<Response<FoodServicesProductDetailsRoot>> GetFoodServicesProductsDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<FoodServicesProductDetailsRoot>(url, cancellationToken);
            }


            public async Task<Response<TermsListRoot>> GetTermsListDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<TermsListRoot>(url, cancellationToken);
            }
            public async Task<Response<TermsExamScheduleRoot>> GetTermsExamScheduleDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<TermsExamScheduleRoot>(url, cancellationToken);
            }
            public async Task<Response<TermsCourseScheduleRoot>> GetTermsCourseScheduleDataTaskAsync(string url, CancellationToken cancellationToken)
            {
                return await GetDataTaskAsync<TermsCourseScheduleRoot>(url, cancellationToken);
            }
            public async Task<Response<TermsSubjectScheduleRoot>> GetTermsSubjectScheduleDataTaskAsync(string url,CancellationToken cancellationToken)
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

        public DateTime TimeStamp { get; set; }
    }
}
