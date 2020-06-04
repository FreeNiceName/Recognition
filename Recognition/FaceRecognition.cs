using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Recognition
{
    public class FaceRecognition : IRecognition
    {
        private const string URL = "https://cv.faifly.com/face/find-match";

        public RecognitionResult Run(string imagePath)
        {
            var response = RequestHelper.SendImage(URL, imagePath);
            return GetResultFromResponse(response);
        }

        private RecognitionResult GetResultFromResponse(HttpResponseMessage response)
        {
            var result = new RecognitionResult();

            if(response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                dynamic json = JObject.Parse(content);
                if(json.result == "Found match")
                {
                    result.IsAccessGiven = true;
                    result.Name = json.names[0];
                }
            }

            return result;
        }
    }
}
