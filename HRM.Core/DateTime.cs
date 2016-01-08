using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Core
{
     using System;
  

    public static class DateTimeExtensions
    {
        /// <summary>
        ///     Converts a UTC DateTime to a DateTime in the specified time zone
        /// </summary>
        /// <remarks>
        ///     Note: the DateTime here must have a "Kind" of Utc.
        /// </remarks>
        //public static DateTime ConvertUTCToLocal(this DateTime utcDateTime, string localTimeZoneId)
        //{
        //    Require.NotNullOrEmpty(localTimeZoneId, "localTimeZoneId");
        //    if (utcDateTime.Kind != DateTimeKind.Utc)
        //    {
        //        throw new ArgumentException("DateTime must be of DateTimeKind: Utc", "utcDateTime");
        //    }

        //    var localTimeZone = GetTimeZone(localTimeZoneId);

        //    var instant = Instant.FromDateTimeUtc(utcDateTime);
        //    var zonedDateTime = instant.InZone(localTimeZone);
        //    return zonedDateTime.ToDateTimeUnspecified();
        //}

        /// <summary>
        ///     Convert a local DateTime to UTC
        /// </summary>
        /// <remarks>
        ///     NOTE: The DateTime here should have a "Kind" of Unspecified
        /// </remarks>
        //public static DateTime ConvertLocalToUTC(this DateTime localDateTime, string localTimeZoneId)
        //{
        //    Require.NotNullOrEmpty(localTimeZoneId, "localTimeZoneId");

        //    var timeZone = GetTimeZone(localTimeZoneId);

        //    var local = LocalDateTime.FromDateTime(localDateTime);
        //    var zonedDbDateTime = timeZone.AtLeniently(local);
        //    return zonedDbDateTime.ToDateTimeUtc();
        //}

        //private static DateTimeZone GetTimeZone(string timeZoneId)
        //{
        //    var timeZoneProvider = GetTimeZoneProvider();
        //    var timeZone = timeZoneProvider[timeZoneId];
        //    return timeZone;
        //}

        //private static IDateTimeZoneProvider GetTimeZoneProvider()
        //{
        //    // use Base Class Library Timezones (i.e. TimeZoneInfo.GetSystemTimeZones() )
        //    return DateTimeZoneProviders.Bcl;
        //}
    }
}
