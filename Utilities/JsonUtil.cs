using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWOpenDataLib.Utilities
{
    public class JsonUtil
    {
        public async Task<T> GetJsonDataResponseAsync<T>(String uriString, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                Debug.WriteLine("Cancelled before task started");
                cancellationToken.ThrowIfCancellationRequested();
            }

            var webUtil = new WebUtil();
            var jsonString = await webUtil.GetWebDataResponseAsync(uriString, cancellationToken);

            if (cancellationToken.IsCancellationRequested)
            {
                Debug.WriteLine("Cancelled after web response completed");
                cancellationToken.ThrowIfCancellationRequested();
            }

            var jsonResponse = await JsonConvert.DeserializeObjectAsync<T>(jsonString);
            return jsonResponse;
        }
    }
}
