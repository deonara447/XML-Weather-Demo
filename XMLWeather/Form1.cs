/*
 * Description: World Wide Weather is a weather app, which extracts weather data from OpenWeatherMap. 
 * It can show the current weather, as well as the forecast for any location. Specifically, it shows 
 * the current temperature humidity, wind, sunset, and sunrise times, as well as the high and low temperatures and the outdoor conditions for the next 7 days.
 * Author: Deo Narayan         
 * Date: April 22, 2020    
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.Diagnostics;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // list to hold day objects
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            //initial extract of stratford
            ExtractForecast("Stratford", "Ca");
            ExtractCurrent("Stratford", "Ca");

            // open choose city screen
            FindCityScreen fcs = new FindCityScreen();
            this.Controls.Add(fcs);
        }

        /// <summary>
        /// This method will get forecast information for each day, including today.
        /// Each day will be setup as a separate Day object and added to the days list. 
        /// </summary>
        public void ExtractForecast(string city, string countryCode)
        {
            //restart days every extract
            days.Clear();

            // get forecast information from web and place in an xml fileC:\Users\deona\Source\Repos\deonara447\XML-Weather-Demo\XMLWeather\Resources\09n.png
            //city and country code deterine location
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=" + city + "," + countryCode + "&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            // extract the relevant information for a day, and repeat for each day in the forecast
            while (reader.Read())
            {
                // create blank day object
                Day d = new Day();
                
                //find appropriate icon
                reader.ReadToFollowing("symbol");
                d.icon = reader.GetAttribute("var");

                //find the temperature element, and get the min and max attributes
                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");

                // add day to days list
                days.Add(d);
            }
        }

        /// <summary>
        /// This method will get the current conditions from the web, convert them to an XML file,
        /// and then use that file to extract information that is not in the forecast file, 
        /// such as the current temperature
        /// </summary>
        public void ExtractCurrent(string city, string countryCode)
        {
            // get current information from web and place in an xml file
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=" + city + "," + countryCode + "&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            // find the city element, and add it's name attribute to days[0], (today)
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            //determine time zone
            reader.ReadToFollowing("timezone");
            days[0].timeZone = reader.ReadString();

            //determine sunrise and sunset times
            reader.ReadToFollowing("sun");
            days[0].sunrise = reader.GetAttribute("rise");
            days[0].sunset = reader.GetAttribute("set");

            // find the temperature element and add the value attribute, (current temp), to days[0], (today)
            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            //determine humidity%
            reader.ReadToFollowing("humidity");
            days[0].humidity = reader.GetAttribute("value");

            //determine wind speed
            reader.ReadToFollowing("speed");
            days[0].windSpeed = reader.GetAttribute("value");

            //determine wind direction
            reader.ReadToFollowing("direction");
            days[0].windDirection = reader.GetAttribute("code");

            //determine weather condition
            reader.ReadToFollowing("weather");
            days[0].condition = reader.GetAttribute("value");

            //find appropriate icon
            days[0].icon = reader.GetAttribute("icon");

            //determine last update time
            reader.ReadToFollowing("lastupdate");
            days[0].updateTime = reader.GetAttribute("value");
        }
    }
}
