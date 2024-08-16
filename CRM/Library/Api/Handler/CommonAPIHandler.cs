﻿using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace ZCRMSDK.CRM.Library.Api.Handler
{
    public class CommonAPIHandler : IAPIHandler
    {
        protected APIConstants.RequestMethod requestMethod;
        protected string urlPath;
        protected Dictionary<string, string> requestHeaders = new Dictionary<string, string>();
        protected Dictionary<string, string> requestQueryParams = new Dictionary<string, string>();
        protected bool isBulk;
        protected JObject requestBody = new JObject();

        public JObject GetRequestBody() { return requestBody; }

        public Dictionary<string, string> GetRequestHeaders() { return requestHeaders; }

        public APIConstants.RequestMethod GetRequestMethod() { return requestMethod; }

        public Dictionary<string, string> GetRequestQueryParams() { return requestQueryParams; }

        public string GetUrlPath() { return urlPath; }
        
        public bool IsBulk() { return isBulk; }
    }
}
