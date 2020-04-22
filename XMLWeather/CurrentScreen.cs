using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();

            //show data from api
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            // the current information is in index 0, thus why all information is retreived from there
            //city
            cityOutput.Text = Form1.days[0].location;

            //current temp
            tempLabel.Text = Math.Round(Convert.ToDouble(Form1.days[0].currentTemp), 0) + "°C";

            //conditions
            conditionOutput.Text = Form1.days[0].condition;

            //rounded high low temps
            minOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempLow), 0) + "°";
            maxOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempHigh), 0) + "°";

            //sunrise and sunset, account for time zone
            riseOutput.Text = Convert.ToDateTime(Form1.days[0].sunrise).AddSeconds(Convert.ToInt32(Form1.days[0].timeZone)).ToString("h:mm tt");
            setOutput.Text = Convert.ToDateTime(Form1.days[0].sunset).AddSeconds(Convert.ToInt32(Form1.days[0].timeZone)).ToString("h:mm tt");

            //humidity
            humidityOutput.Text = Form1.days[0].humidity + "%";

            //wind speed (rounded) and direction, (converted from m/s to km/h)
            windOutput.Text = Form1.days[0].windDirection + " " + Math.Round(3.6 *Convert.ToDouble(Form1.days[0].windSpeed), 0) + " km/h";

            //local time converted to time in location
            dateLabel.Text = DateTime.Now.AddSeconds(Convert.ToInt32(Form1.days[0].timeZone) + 14400).ToString("dddd") + ", " 
                + DateTime.Now.AddSeconds(Convert.ToInt32(Form1.days[0].timeZone) + 14400).ToString("MMM dd") + ", " + DateTime.Now.ToString("yyyy");

            //last local time data was updated
            updateLabel.Text = "Last Updated at " + Convert.ToDateTime(Form1.days[0].updateTime).AddHours(-4).ToString("h:mm");

            //background image dependent on weather
            //if clear sky day
            if (Form1.days[0].icon == "01d")
            {
                this.BackgroundImage = Properties.Resources._01dp;
            }
            //if clear sky night
            else if (Form1.days[0].icon == "01n")
            {
                this.BackgroundImage = Properties.Resources._01np;
            }
            //if few clouds
            else if (Form1.days[0].icon == "02d")
            {
                this.BackgroundImage = Properties.Resources._02dp;
            }
            else if (Form1.days[0].icon == "02n")
            {
                this.BackgroundImage = Properties.Resources._02np;
            }
            //if scattered clouds
            else if (Form1.days[0].icon == "03d")
            {
                this.BackgroundImage = Properties.Resources._03dp;
            }
            else if (Form1.days[0].icon == "03n")
            {
                this.BackgroundImage = Properties.Resources._03np;
            }
            //if very cloudy
            else if (Form1.days[0].icon == "04d")
            {
                this.BackgroundImage = Properties.Resources._04dp;
            }
            else if (Form1.days[0].icon == "04n")
            {
                this.BackgroundImage = Properties.Resources._04np;
            }
            //if rainy
            else if (Form1.days[0].icon == "10d" || Form1.days[0].icon == "10n"|| Form1.days[0].icon == "09d"|| Form1.days[0].icon == "09n")
            {
                this.BackgroundImage = Properties.Resources._10;
            }
            //if thunderstrom
            else if (Form1.days[0].icon == "11d" || Form1.days[0].icon == "11n")
            {
                this.BackgroundImage = Properties.Resources._11;
            }
            //if snow
            else if (Form1.days[0].icon == "13d")
            {
                this.BackgroundImage = Properties.Resources._13dp;
            }
            else if (Form1.days[0].icon == "13n")
            {
                this.BackgroundImage = Properties.Resources._13np;
            }
            //if misty
            else if (Form1.days[0].icon == "50d")
            {
                this.BackgroundImage = Properties.Resources._50dp;
            }
            else if (Form1.days[0].icon == "50n")
            {
                this.BackgroundImage = Properties.Resources._50np;
            }
        }

        /// <summary>
        /// When the forecast label is clicked this user control is removed from the form
        /// and the ForecastScreen user control is added to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void forecastLabel_Click(object sender, EventArgs e)
        {
            //goes to forecast screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void findCityLabel_Click(object sender, EventArgs e)
        {
            //goes to find city screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            FindCityScreen fcs = new FindCityScreen();
            f.Controls.Add(fcs);
        }
    }
}
