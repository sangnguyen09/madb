﻿// <copyright file="DateTimeHelper.cs" company="The Android Open Source Project, Ryan Conrad, Quamotion">
// Copyright (c) The Android Open Source Project, Ryan Conrad, Quamotion. All rights reserved.
// </copyright>

namespace Managed.Adb
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    /// <ignore>true</ignore>
    public static partial class ManagedAdbExtenstions
    {
        /// <summary>
        /// Gets EPOCH time
        /// </summary>
        public static DateTime Epoch
        {
            get;
            private set;
        } = new DateTime(1970, 1, 1);

        /// <summary>
        /// Gets epoch time.
        /// </summary>
        /// <param name="dt">The dt.</param>
        /// <returns></returns>
        public static DateTime GetEpoch(this DateTime dt)
        {
            return Epoch;
        }

        /// <summary>
        /// Currents the time millis.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <returns></returns>
        public static long CurrentTimeMillis(this DateTime dateTime)
        {
            return (long)(dateTime.ToUniversalTime() - Epoch).TotalMilliseconds;
        }

        /// <summary>
        /// Converts a DateTime to Unix Epoch
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public static long ToUnixEpoch(this DateTime date)
        {
            TimeSpan t = (date - Epoch);
            long epoch = (long)t.TotalSeconds;
            return epoch;
        }

        /// <summary>
        /// Creates a DateTime from the seconds since Epoch
        /// </summary>
        /// <param name="seconds">The seconds.</param>
        /// <returns></returns>
        public static DateTime ToDateTimeFromUnixEpoch(this int seconds)
        {
            DateTime epoch = Epoch;
            DateTime ret = epoch.Add(new TimeSpan(0, 0, seconds));
            return ret;
        }

        /// <summary>
        /// Creates a DateTime from a string
        /// </summary>
        /// <param name="dateString">The date string.</param>
        /// <returns></returns>
        public static DateTime ToDateTimeFromString(this string dateString)
        {
            return DateTime.Parse(dateString);
        }

        /// <summary>
        /// Creates a DateTime from a string
        /// </summary>
        /// <param name="dateString">The date string.</param>
        /// <param name="format">The format.</param>
        /// <returns></returns>
        public static DateTime ToDateTimeFromString(this string dateString, IFormatProvider format)
        {
            return DateTime.Parse(dateString, format);
        }

        /// <summary>
        /// Creates a DateTime from a string
        /// </summary>
        /// <param name="dateString">The date string.</param>
        /// <param name="format">The format.</param>
        /// <param name="styles">The styles.</param>
        /// <returns></returns>
        public static DateTime ToDateTimeFromString(this string dateString, IFormatProvider format, DateTimeStyles styles)
        {
            return DateTime.Parse(dateString, format, styles);
        }

        /// <summary>
        /// Creates a DateTime from a binary value
        /// </summary>
        /// <param name="dateData">The date data.</param>
        /// <returns></returns>
        public static DateTime ToDateTimeFromBinary(this long dateData)
        {
            return DateTime.FromBinary(dateData);
        }

        /// <summary>
        /// Creates a DateTime from a file time
        /// </summary>
        /// <param name="fileTime">The file time.</param>
        /// <returns></returns>
        public static DateTime ToDateTimeFromFileTime(this long fileTime)
        {
            return DateTime.FromFileTime(fileTime);
        }

        /// <summary>
        /// Creates a DateTime from a file time UTC
        /// </summary>
        /// <param name="fileTime">The file time.</param>
        /// <returns></returns>
        public static DateTime ToDateTimeFromFileTimeUtc(this long fileTime)
        {
            return DateTime.FromFileTimeUtc(fileTime);
        }

        /// <summary>
        /// Creates a DateTime from an OA Date
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public static DateTime ToDateTimeFromOADate(this double date)
        {
            return DateTime.FromOADate(date);
        }
    }
}
