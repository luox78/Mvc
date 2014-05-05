// Copyright (c) Microsoft Open Technologies, Inc.
// All Rights Reserved
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING
// WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF
// TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR
// NON-INFRINGEMENT.
// See the Apache 2 License for the specific language governing
// permissions and limitations under the License.

using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNet.Http;

namespace Microsoft.AspNet.Mvc
{
    // Provides an abstraction around something that can validate anti-XSRF tokens
    internal interface ITokenValidator
    {
        // Determines whether an existing cookie token is valid (well-formed).
        // If it is not, the caller must call GenerateCookieToken() before calling GenerateFormToken().
        bool IsCookieTokenValid(AntiForgeryToken cookieToken);

        // Validates a (cookie, form) token pair.
        void ValidateTokens(HttpContext httpContext, ClaimsIdentity identity, AntiForgeryToken cookieToken, AntiForgeryToken formToken);
    }
}