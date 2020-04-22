using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string currentTemp, updateTime, condition, location, tempHigh, tempLow, 
            windSpeed, windDirection, humidity, sunrise, sunset, icon, timeZone;

        /// <summary>
        /// This will create a blank day object where all values are set to "" initially
        /// </summary>
        public Day()
        {
            currentTemp = updateTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = humidity = sunrise = sunset = icon = timeZone = "";
        }
    }
}
