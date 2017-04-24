// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using Microsoft.Owin.Security;
using Mcpelee.Owin.Security.Daum;

namespace Owin
{
    /// <summary>
    /// Extension methods for using <see cref="DaumAuthenticationMiddleware"/>
    /// </summary>
    public static class DaumAuthenticationExtensions
    {
        /// <summary>
        /// Authenticate users using Daum
        /// </summary>
        /// <param name="app">The <see cref="IAppBuilder"/> passed to the configuration method</param>
        /// <param name="options">Middleware configuration options</param>
        /// <returns>The updated <see cref="IAppBuilder"/></returns>
        public static IAppBuilder UseDaumAuthentication(this IAppBuilder app, DaumAuthenticationOptions options)
        {
            if (app == null)
            {
                throw new ArgumentNullException("app");
            }
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }

            app.Use(typeof(DaumAuthenticationMiddleware), app, options);
            return app;
        }

        /// <summary>
        /// Authenticate users using Daum
        /// </summary>
        /// <param name="app">The <see cref="IAppBuilder"/> passed to the configuration method</param>
        /// <param name="appId">The appId assigned by Daum</param>
        /// <param name="appSecret">The appSecret assigned by Daum</param>
        /// <returns>The updated <see cref="IAppBuilder"/></returns>
        public static IAppBuilder UseDaumAuthentication(
            this IAppBuilder app,
            string appId,
            string appSecret)
        {
            return UseDaumAuthentication(
                app,
                new DaumAuthenticationOptions
                {
                    AppId = appId,
                    AppSecret = appSecret,
                });
        }
    }
}
