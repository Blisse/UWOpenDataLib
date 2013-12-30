using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UWOpenDataLib.Extensions
{
    public static class WebExtensions
    {
        public static Task<HttpWebResponse> GetWebResponseTaskAsync(this HttpWebRequest request, CancellationToken cancellationToken)
        {
            var taskComplete = new TaskCompletionSource<HttpWebResponse>(cancellationToken);
            request.BeginGetResponse(asyncResponse =>
            {
                try
                {
                    var responseRequest = (HttpWebRequest)asyncResponse.AsyncState;
                    var someResponse = (HttpWebResponse)responseRequest.EndGetResponse(asyncResponse);
                    taskComplete.TrySetResult(someResponse);
                }
                catch (WebException webExc)
                {
                    Debug.WriteLine("Exception in HttpWebResponse async callback.");
                    var failedResponse = (HttpWebResponse)webExc.Response;
                    taskComplete.TrySetResult(failedResponse);
                }
            }, request);
            return taskComplete.Task;
        }

        public static Task<String> GetWebResponseStringTaskAsync(this HttpWebResponse response, CancellationToken cancellationToken)
        {
            var taskComplete = new TaskCompletionSource<String>(cancellationToken);
            try
            {
                var responseStream = response.GetResponseStream();
                using (var streamReader = new StreamReader(responseStream))
                {
                    var responseString = streamReader.ReadToEnd();
                    taskComplete.TrySetResult(responseString);
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine("Exception in HttpWebResponse async callback.");
                taskComplete.SetException(exception);
            }
            return taskComplete.Task;
        }
    }
}
