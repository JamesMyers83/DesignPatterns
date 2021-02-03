using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace DesignPatterns.Structural.Proxy
{
    //standard class from my personal library for HTTP requests
    public class HttpUtility
    {
        public HttpUtility()
        {
            CookieJar = new CookieContainer();
            CustomHeaders = new Dictionary<string, string>();
        }

        private CookieContainer CookieJar { get; set; }
        public enum HttpRequestMethods { GET, POST, PATCH };
        public string PostData { get; set; }
        public Dictionary<string, string> CustomHeaders { get; set; }

        public string GetHttpResponseText(string httpUrl, HttpRequestMethods requestMethod)
        {
            HttpWebRequest req;
            req = (HttpWebRequest)WebRequest.Create(httpUrl);
            req.ContentType = "application/json";
            req.KeepAlive = true;
            req.AllowAutoRedirect = true;
            req.CookieContainer = CookieJar;
            req.Method = Enum.GetName(typeof(HttpRequestMethods), requestMethod);

            if (CustomHeaders.Count > 0)
                foreach (KeyValuePair<string, string> header in CustomHeaders)
                    req.Headers.Add(header.Key, header.Value);


            switch (requestMethod)
            {
                case HttpRequestMethods.GET:
                    break;
                case HttpRequestMethods.POST:
                    AddPostDataToRequest(ref req);
                    break;
                case HttpRequestMethods.PATCH:
                    AddPostDataToRequest(ref req);
                    break;
                default:
                    break;
            }

            StreamReader sr;
            HttpWebResponse resp;

            try
            {
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException ex)
            {
                resp = (HttpWebResponse)ex.Response;

                switch (resp.StatusCode)
                {
                    case HttpStatusCode.InternalServerError: // 500
                        break;

                    default:
                        throw;
                }
            }

            sr = new StreamReader(resp.GetResponseStream());
            string HTTPResponse = sr.ReadToEnd();

            sr.Close();
            resp.Close();
            return HTTPResponse;
        }

        public void AddCustomHeader(string name, string value)
        {
            CustomHeaders.Add(name, value);
        }

        private void AddPostDataToRequest(ref HttpWebRequest req)
        {
            req.ContentLength = PostData.Length;
            StreamWriter sw = new StreamWriter(req.GetRequestStream());
            sw.Write(PostData);
            sw.Close();
        }
    }
}