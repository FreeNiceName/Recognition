using System.Net.Http;
using System.IO;

namespace Recognition
{
    public static class RequestHelper
    {
        public static HttpResponseMessage SendImage(string URL, string imagePath)
        {
            using (var httpClient = new HttpClient())
            {
                var form = new MultipartFormDataContent();
                var fileBytes = File.ReadAllBytes(imagePath);
                var content = new ByteArrayContent(fileBytes);
                form.Add(content, "image", imagePath);
                return httpClient.PostAsync(URL, form).Result;
            }
        }
    }
}
