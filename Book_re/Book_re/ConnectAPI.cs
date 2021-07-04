using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Book_re
{
    class ConnectAPI
    {
        private string GetRequestResult(string openApiUrl, string clientId, string clientSecret)
        {
            var requestResult = String.Empty;

            try
            {
                WebRequest request = null;

                request = WebRequest.Create("https://openapi.naver.com/v1/search/book_adv.xml");

                request.Headers.Add("X-Naver-Client-Id", "l87hDaOsW43gnG4tEuHr");
                request.Headers.Add("X-Naver-Client-Secret", "hbrV0_tmzo");

                Stream dataStream = null;

                var response = request.GetResponse();
                dataStream = response.GetResponseStream();
                var reader = new StreamReader(dataStream);
                requestResult = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return requestResult;
        }
    }
}
