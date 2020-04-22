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
    public partial class FindCityScreen : UserControl
    {
        public FindCityScreen()
        {
            InitializeComponent();

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
            else if (Form1.days[0].icon == "10d" || Form1.days[0].icon == "10n" || Form1.days[0].icon == "09d" || Form1.days[0].icon == "09n")
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

        private void searchLabel_Click(object sender, EventArgs e)
        {
            //store city and country
            string city = cityTextBox.Text;
            string countryCode = countryCodeTextBox.Text;
          
            Form f = this.FindForm();
            Form1 fs = new Form1();

            //if real location
            try
            {
                //extract weather data for location
                fs.ExtractForecast(city, countryCode);
                fs.ExtractCurrent(city, countryCode);

                //switch to current screen
                f.Controls.Remove(this);
                CurrentScreen cs = new CurrentScreen();
                f.Controls.Add(cs);
            }

            //if not real location
            catch
            {
                //show error
                errorLabel.Visible = true;

                //use default location (stratford)
                fs.ExtractForecast("Stratford", "Ca");
                fs.ExtractCurrent("Stratford", "Ca");
            }
        }

        private void currentLabel_Click(object sender, EventArgs e)
        {
            //switch to current screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            //switch to forecast screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
