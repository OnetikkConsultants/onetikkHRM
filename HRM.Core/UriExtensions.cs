using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Core
{
    public static class UriExtensions
    {
        public static Uri Combine(this Uri baseUri, string relativePath)
        {
            Require.NotNull(baseUri, "baseUri");
            Require.NotNull(relativePath, "relativePath");
            var ub = new UriBuilder(baseUri);
            if (!ub.Path.EndsWith("/") && !relativePath.StartsWith("/"))
            {
                ub.Path += "/";
            }

            ub.Path += relativePath;

            return ub.Uri;
        }

        public static string ToProtocolRelativeString(this Uri uri)
        {
            Require.NotNull(uri, "uri");

            var idx = 1 + uri.AbsoluteUri.IndexOf(Uri.SchemeDelimiter, StringComparison.OrdinalIgnoreCase);
            return uri.AbsoluteUri.Substring(idx);
        }
    }
}
