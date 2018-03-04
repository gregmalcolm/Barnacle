using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace Barnacle.Services
{
    public class Http
    {
        private static Http _instance;

        public HttpClient HttpClient { get; }  = new HttpClient();

        private Http() { }

        public static Http Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Http();
                }
                return _instance;
            }
        }

    }
}
