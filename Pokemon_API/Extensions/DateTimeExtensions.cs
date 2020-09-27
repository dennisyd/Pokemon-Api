/* <copyright file="DarkSky_Microservice.Extensions.DateTimeExtensions.cs" company="S.I.D" author="Dan Flanagan">
 * Copyright (C) 2019 S.I.D LLC.
 * </copyright>
 * ----------------------------
 */

using System;

namespace Pokemon_API.Extensions
{
    /// <summary>
    /// Extension Methods for System.DateTime
    /// </summary>
    public static class DateTimeExtensions
    {
        public static DateTime UnixToDateTime(this double time)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(time).ToLocalTime();
            return dtDateTime;
        }

        public static DateTime ToUnix(this int time)
        {
            return UnixToDateTime((double)time);
        }

        public static int ToUnix(this DateTime time)
        {
            Int32 unixTimestamp = (Int32)(time.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            return unixTimestamp;
        }
    }
}