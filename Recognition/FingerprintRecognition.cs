using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Recognition
{
    public class FingerprintRecognition : IRecognition
    {
        private const string URL = "https://cv.faifly.com/fingerprint/find-match";

        public RecognitionResult Run(string imagePath)
        {
            var response = RequestHelper.SendImage(URL, imagePath);
            return GetResultFromResponse(response);
        }

        private RecognitionResult GetResultFromResponse(HttpResponseMessage response)
        {
            var result = new RecognitionResult();

            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                dynamic json = JObject.Parse(content);
                result.IsAccessGiven = true;
                result.Name = json.name;
            }

            return result;
        }
    }
}
