// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace Mcpelee.Owin.Security.Daum
{
    internal static class Constants
    {
        public const string DefaultAuthenticationType = "Daum";

        internal const string AuthorizationEndpoint = "https://apis.daum.net/oauth2/authorize";
        internal const string TokenEndpoint = "https://apis.daum.net/oauth2/token";
        internal const string UserInformationEndpoint = "https://apis.daum.net/user/v1/show.json";
    }
}
