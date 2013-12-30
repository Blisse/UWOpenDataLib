using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UWOpenDataLib.Extensions;

namespace UWOpenDataLib.Utilities
{
    public class WebUtil
    {
        public async Task<String> GetWebDataResponseAsync(String uriString, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                Debug.WriteLine("Cancelled before task started");
                cancellationToken.ThrowIfCancellationRequested();
            }

            HttpWebRequest request = CreateHttpGetRequest(uriString);
            var response = await request.GetWebResponseTaskAsync(cancellationToken);

            if (cancellationToken.IsCancellationRequested)
            {
                Debug.WriteLine("Cancelled after web response completed");
                cancellationToken.ThrowIfCancellationRequested();
            }

            var responseString = await response.GetWebResponseStringTaskAsync(cancellationToken);
            return responseString;
        }
            
        private HttpWebRequest CreateHttpGetRequest(String uriString)
        {
            return CreateHttpGetRequest(new Uri(uriString, UriKind.Absolute));
        }
        private HttpWebRequest CreateHttpGetRequest(Uri uri)
        {
            var request = (HttpWebRequest) WebRequest.Create(uri);
            return SetUpHttpGetRequest(request);
        }
        private HttpWebRequest SetUpHttpGetRequest(HttpWebRequest request)
        {
            request.Method = "GET";
            request.Accept = "application/json;odata=verbose";
            return request;
        }
    }
}
