﻿using System;
using ZCRMSDK.OAuth.Common;

namespace ZCRMSDK.OAuth.Contract
{
    public class ZohoOAuthParams
    {
        private string clientId;
        private string clientSecret;
        private string redirectURL;
        private string accessType;
        private string scopes;

        public ZohoOAuthParams() { }

        public string ClientId
        {
            get
            {
                return clientId;
            }
            set
            {
                clientId = value;
            }
        }

        public string ClientSecret
        {
            get
            {
                return clientSecret;
            }
            set
            {
                clientSecret = value;
            }
        }
       
        public string RedirectURL
        {
            get
            {
                return redirectURL;
            }
            set
            {
                redirectURL = value;
            }
        }

        public string AccessType
        {
            get
            {
                return accessType;
            }
            set
            {
                accessType = value;
            }
        }

        public string Scopes {
            get
            {
                return scopes;
            }
            set { 
                if((scopes != null) && (scopes.Contains(ZohoOAuthConstants.IAM_SCOPE))){
                    scopes = value + ","+ZohoOAuthConstants.IAM_SCOPE;
                }
                scopes = value;
            }
        }
    }
}
