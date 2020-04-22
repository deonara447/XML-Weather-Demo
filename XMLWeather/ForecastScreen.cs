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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();

            //show data
            displayForecast();
        }

        /// <summary>
        /// This method displays forecast information. The information in days at 
        /// index 1 is tomorrow's information, 2 is 2 days from now, etc. 
        /// </summary>
        public void displayForecast()
        {
            //city
            cityOutput.Text = Form1.days[0].location;

            //display days, account for different time zones
            day2Label.Text = DateTime.Now.AddDays(1).AddSeconds(Convert.ToInt32(Form1.days[0].timeZone) + 14400).ToString("dddd");
            day3Label.Text = DateTime.Now.AddDays(2).AddSeconds(Convert.ToInt32(Form1.days[0].timeZone) + 14400).ToString("dddd");
            day4Label.Text = DateTime.Now.AddDays(3).AddSeconds(Convert.ToInt32(Form1.days[0].timeZone) + 14400).ToString("dddd");
            day5Label.Text = DateTime.Now.AddDays(4).AddSeconds(Convert.ToInt32(Form1.days[0].timeZone) + 14400).ToString("dddd");
            day6Label.Text = DateTime.Now.AddDays(5).AddSeconds(Convert.ToInt32(Form1.days[0].timeZone) + 14400).ToString("dddd");
            day7Label.Text = DateTime.Now.AddDays(6).AddSeconds(Convert.ToInt32(Form1.days[0].timeZone) + 14400).ToString("dddd");

            //last time data was updated
            updateLabel.Text = "Last Updated at " + Convert.ToDateTime(Form1.days[0].updateTime).AddHours(-4).ToString("h:mm");

            //max temps for each day
            maxOutput1.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempHigh), 0) + "°";
            maxOutput2.Text = Math.Round(Convert.ToDouble(Form1.days[1].tempHigh), 0) + "°";
            maxOutput3.Text = Math.Round(Convert.ToDouble(Form1.days[2].tempHigh), 0) + "°";
            maxOutput4.Text = Math.Round(Convert.ToDouble(Form1.days[3].tempHigh), 0) + "°";
            maxOutput5.Text = Math.Round(Convert.ToDouble(Form1.days[4].tempHigh), 0) + "°";
            maxOutput6.Text = Math.Round(Convert.ToDouble(Form1.days[5].tempHigh), 0) + "°";
            maxOutput7.Text = Math.Round(Convert.ToDouble(Form1.days[6].tempHigh), 0) + "°";

            //min temps for each day
            minOutput1.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempLow), 0) + "°";
            minOutput2.Text = Math.Round(Convert.ToDouble(Form1.days[1].tempLow), 0) + "°";
            minOutput3.Text = Math.Round(Convert.ToDouble(Form1.days[2].tempLow), 0) + "°";
            minOutput4.Text = Math.Round(Convert.ToDouble(Form1.days[3].tempLow), 0) + "°";
            minOutput5.Text = Math.Round(Convert.ToDouble(Form1.days[4].tempLow), 0) + "°";
            minOutput6.Text = Math.Round(Convert.ToDouble(Form1.days[5].tempLow), 0) + "°";
            minOutput7.Text = Math.Round(Convert.ToDouble(Form1.days[6].tempLow), 0) + "°";

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

        private void weatherIcons_Paint(object sender, PaintEventArgs e)
        {
            //specific icon used
            Image iconImage;

            //for each day
            for (int i = 0; i <= 6; i++)
            {
                //specific weather icon for each weather condition group
                if (Form1.days[i].icon == "01d")
                {
                    iconImage = Properties.Resources._01d;
                }
                else if (Form1.days[i].icon == "02d")
                {
                    iconImage = Properties.Resources._02d;
                }
                else if (Form1.days[i].icon == "03d")
                {
                    iconImage = Properties.Resources._03d;
                }
                else if (Form1.days[i].icon == "04d")
                {
                    iconImage = Properties.Resources._04d;
                }
                else if (Form1.days[i].icon == "09d")
                {
                    iconImage = Properties.Resources._09d;
                }
                else if (Form1.days[i].icon == "10d")
                {
                    iconImage = Properties.Resources._10d;
                }
                else if (Form1.days[i].icon == "11d")
                {
                    iconImage = Properties.Resources._11d;
                }
                else if (Form1.days[i].icon == "13d")
                {
                    iconImage = Properties.Resources._13d;
                }
                else if (Form1.days[i].icon == "50d")
                {
                    iconImage = Properties.Resources._50d;
                }
                else if (Form1.days[i].icon == "01n")
                {
                    iconImage = Properties.Resources._01n;
                }
                else if (Form1.days[i].icon == "02n")
                {
                    iconImage = Properties.Resources._02n;
                }
                else if (Form1.days[i].icon == "03n")
                {
                    iconImage = Properties.Resources._03n;
                }
                else if (Form1.days[i].icon == "04n")
                {
                    iconImage = Properties.Resources._04n;
                }
                else if (Form1.days[i].icon == "09n")
                {
                    iconImage = Properties.Resources._09n;
                }
                else if (Form1.days[i].icon == "10n")
                {
                    iconImage = Properties.Resources._10n;
                }
                else if (Form1.days[i].icon == "11n")
                {
                    iconImage = Properties.Resources._11n;
                }
                else if (Form1.days[i].icon == "13n")
                {
                    iconImage = Properties.Resources._13n;
                }
                else
                {
                    iconImage = Properties.Resources._50n;
                }

                //returns resized image
                iconImage = resizeImage(iconImage, new Size(45, 45));

                //draws speciic icon at specific size and y value of location increases at a constant
                e.Graphics.DrawImage(iconImage, 101, 72 + 38*i);
            }


            //string test = Properties.Resources.("test");
         

          //  // Draw image to screen.
          ////  e.Graphics.DrawImage(, 100, 100);
        }

        /// <summary>
        /// When the Today label is clicked, this user control is removed from the form
        /// and the CurrentScreen user control is added to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void todayLabel_Click(object sender, EventArgs e)
        {
            //switch to current screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void findCityLabel_Click(object sender, EventArgs e)
        {
            //switch to find city screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            FindCityScreen fcs = new FindCityScreen();
            f.Controls.Add(fcs);
        }

        //returns resized images
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
    }
}
