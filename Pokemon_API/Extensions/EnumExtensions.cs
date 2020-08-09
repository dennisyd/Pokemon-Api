/* <copyright file="DarkSky_Microservice.Extensions.EnumExtensions.cs" company="S.I.D" author="Dan Flanagan">
 * Copyright (C) 2019 S.I.D LLC.
 * </copyright>
 * ----------------------------
 */

using System;

namespace DarkSkyMicroservice.Extensions
{
    public static class EnumExtensions
    {
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}