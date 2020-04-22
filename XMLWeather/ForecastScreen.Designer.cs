namespace XMLWeather
{
    partial class ForecastScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.forecastLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.findCityLabel = new System.Windows.Forms.Label();
            this.line2Label = new System.Windows.Forms.Label();
            this.line1Label = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.day1Label = new System.Windows.Forms.Label();
            this.day2Label = new System.Windows.Forms.Label();
            this.day3Label = new System.Windows.Forms.Label();
            this.day4Label = new System.Windows.Forms.Label();
            this.updateLabel = new System.Windows.Forms.Label();
            this.day5Label = new System.Windows.Forms.Label();
            this.day6Label = new System.Windows.Forms.Label();
            this.day7Label = new System.Windows.Forms.Label();
            this.maxOutput1 = new System.Windows.Forms.Label();
            this.minOutput1 = new System.Windows.Forms.Label();
            this.maxOutput2 = new System.Windows.Forms.Label();
            this.maxOutput4 = new System.Windows.Forms.Label();
            this.maxOutput3 = new System.Windows.Forms.Label();
            this.maxOutput6 = new System.Windows.Forms.Label();
            this.maxOutput5 = new System.Windows.Forms.Label();
            this.maxOutput7 = new System.Windows.Forms.Label();
            this.minOutput7 = new System.Windows.Forms.Label();
            this.minOutput6 = new System.Windows.Forms.Label();
            this.minOutput5 = new System.Windows.Forms.Label();
            this.minOutput4 = new System.Windows.Forms.Label();
            this.minOutput3 = new System.Windows.Forms.Label();
            this.minOutput2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(333, 716);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(167, 53);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "Forecast";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentLabel
            // 
            this.currentLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.currentLabel.ForeColor = System.Drawing.Color.White;
            this.currentLabel.Location = new System.Drawing.Point(167, 716);
            this.currentLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(167, 53);
            this.currentLabel.TabIndex = 61;
            this.currentLabel.Text = "Current";
            this.currentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.currentLabel.Click += new System.EventHandler(this.todayLabel_Click);
            // 
            // findCityLabel
            // 
            this.findCityLabel.BackColor = System.Drawing.Color.Transparent;
            this.findCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.findCityLabel.ForeColor = System.Drawing.Color.White;
            this.findCityLabel.Location = new System.Drawing.Point(0, 716);
            this.findCityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.findCityLabel.Name = "findCityLabel";
            this.findCityLabel.Size = new System.Drawing.Size(167, 53);
            this.findCityLabel.TabIndex = 70;
            this.findCityLabel.Text = "Find City";
            this.findCityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.findCityLabel.Click += new System.EventHandler(this.findCityLabel_Click);
            // 
            // line2Label
            // 
            this.line2Label.BackColor = System.Drawing.Color.Transparent;
            this.line2Label.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line2Label.ForeColor = System.Drawing.Color.White;
            this.line2Label.Location = new System.Drawing.Point(0, 664);
            this.line2Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.line2Label.Name = "line2Label";
            this.line2Label.Size = new System.Drawing.Size(500, 52);
            this.line2Label.TabIndex = 72;
            this.line2Label.Text = "____________________________";
            this.line2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // line1Label
            // 
            this.line1Label.BackColor = System.Drawing.Color.Transparent;
            this.line1Label.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line1Label.ForeColor = System.Drawing.Color.White;
            this.line1Label.Location = new System.Drawing.Point(6, 88);
            this.line1Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.line1Label.Name = "line1Label";
            this.line1Label.Size = new System.Drawing.Size(500, 52);
            this.line1Label.TabIndex = 73;
            this.line1Label.Text = "____________________________";
            this.line1Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(2, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(499, 53);
            this.titleLabel.TabIndex = 74;
            this.titleLabel.Text = "World Wide Weather";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(4, 74);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(488, 57);
            this.cityOutput.TabIndex = 75;
            this.cityOutput.Text = "Stratford";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day1Label
            // 
            this.day1Label.AutoSize = true;
            this.day1Label.BackColor = System.Drawing.Color.Transparent;
            this.day1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.day1Label.ForeColor = System.Drawing.Color.White;
            this.day1Label.Location = new System.Drawing.Point(11, 172);
            this.day1Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.day1Label.Name = "day1Label";
            this.day1Label.Size = new System.Drawing.Size(106, 37);
            this.day1Label.TabIndex = 76;
            this.day1Label.Text = "Today";
            // 
            // day2Label
            // 
            this.day2Label.AutoSize = true;
            this.day2Label.BackColor = System.Drawing.Color.Transparent;
            this.day2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.day2Label.ForeColor = System.Drawing.Color.White;
            this.day2Label.Location = new System.Drawing.Point(11, 243);
            this.day2Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.day2Label.Name = "day2Label";
            this.day2Label.Size = new System.Drawing.Size(151, 37);
            this.day2Label.TabIndex = 77;
            this.day2Label.Text = "Thursday";
            // 
            // day3Label
            // 
            this.day3Label.AutoSize = true;
            this.day3Label.BackColor = System.Drawing.Color.Transparent;
            this.day3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.day3Label.ForeColor = System.Drawing.Color.White;
            this.day3Label.Location = new System.Drawing.Point(11, 314);
            this.day3Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.day3Label.Name = "day3Label";
            this.day3Label.Size = new System.Drawing.Size(151, 37);
            this.day3Label.TabIndex = 78;
            this.day3Label.Text = "Thursday";
            // 
            // day4Label
            // 
            this.day4Label.AutoSize = true;
            this.day4Label.BackColor = System.Drawing.Color.Transparent;
            this.day4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.day4Label.ForeColor = System.Drawing.Color.White;
            this.day4Label.Location = new System.Drawing.Point(11, 385);
            this.day4Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.day4Label.Name = "day4Label";
            this.day4Label.Size = new System.Drawing.Size(151, 37);
            this.day4Label.TabIndex = 79;
            this.day4Label.Text = "Thursday";
            // 
            // updateLabel
            // 
            this.updateLabel.BackColor = System.Drawing.Color.Transparent;
            this.updateLabel.ForeColor = System.Drawing.Color.White;
            this.updateLabel.Location = new System.Drawing.Point(2, 676);
            this.updateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(499, 25);
            this.updateLabel.TabIndex = 80;
            this.updateLabel.Text = "Last Updated at";
            this.updateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day5Label
            // 
            this.day5Label.AutoSize = true;
            this.day5Label.BackColor = System.Drawing.Color.Transparent;
            this.day5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.day5Label.ForeColor = System.Drawing.Color.White;
            this.day5Label.Location = new System.Drawing.Point(11, 456);
            this.day5Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.day5Label.Name = "day5Label";
            this.day5Label.Size = new System.Drawing.Size(151, 37);
            this.day5Label.TabIndex = 81;
            this.day5Label.Text = "Thursday";
            // 
            // day6Label
            // 
            this.day6Label.AutoSize = true;
            this.day6Label.BackColor = System.Drawing.Color.Transparent;
            this.day6Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.day6Label.ForeColor = System.Drawing.Color.White;
            this.day6Label.Location = new System.Drawing.Point(11, 527);
            this.day6Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.day6Label.Name = "day6Label";
            this.day6Label.Size = new System.Drawing.Size(151, 37);
            this.day6Label.TabIndex = 82;
            this.day6Label.Text = "Thursday";
            // 
            // day7Label
            // 
            this.day7Label.AutoSize = true;
            this.day7Label.BackColor = System.Drawing.Color.Transparent;
            this.day7Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.day7Label.ForeColor = System.Drawing.Color.White;
            this.day7Label.Location = new System.Drawing.Point(11, 598);
            this.day7Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.day7Label.Name = "day7Label";
            this.day7Label.Size = new System.Drawing.Size(151, 37);
            this.day7Label.TabIndex = 83;
            this.day7Label.Text = "Thursday";
            // 
            // maxOutput1
            // 
            this.maxOutput1.AutoSize = true;
            this.maxOutput1.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maxOutput1.ForeColor = System.Drawing.Color.White;
            this.maxOutput1.Location = new System.Drawing.Point(319, 172);
            this.maxOutput1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.maxOutput1.Name = "maxOutput1";
            this.maxOutput1.Size = new System.Drawing.Size(77, 37);
            this.maxOutput1.TabIndex = 84;
            this.maxOutput1.Text = "max";
            this.maxOutput1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minOutput1
            // 
            this.minOutput1.AutoSize = true;
            this.minOutput1.BackColor = System.Drawing.Color.Transparent;
            this.minOutput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minOutput1.ForeColor = System.Drawing.Color.White;
            this.minOutput1.Location = new System.Drawing.Point(408, 172);
            this.minOutput1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.minOutput1.Name = "minOutput1";
            this.minOutput1.Size = new System.Drawing.Size(69, 37);
            this.minOutput1.TabIndex = 85;
            this.minOutput1.Text = "min";
            this.minOutput1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxOutput2
            // 
            this.maxOutput2.AutoSize = true;
            this.maxOutput2.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maxOutput2.ForeColor = System.Drawing.Color.White;
            this.maxOutput2.Location = new System.Drawing.Point(319, 243);
            this.maxOutput2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.maxOutput2.Name = "maxOutput2";
            this.maxOutput2.Size = new System.Drawing.Size(77, 37);
            this.maxOutput2.TabIndex = 86;
            this.maxOutput2.Text = "max";
            this.maxOutput2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxOutput4
            // 
            this.maxOutput4.AutoSize = true;
            this.maxOutput4.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maxOutput4.ForeColor = System.Drawing.Color.White;
            this.maxOutput4.Location = new System.Drawing.Point(319, 385);
            this.maxOutput4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.maxOutput4.Name = "maxOutput4";
            this.maxOutput4.Size = new System.Drawing.Size(77, 37);
            this.maxOutput4.TabIndex = 88;
            this.maxOutput4.Text = "max";
            this.maxOutput4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxOutput3
            // 
            this.maxOutput3.AutoSize = true;
            this.maxOutput3.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maxOutput3.ForeColor = System.Drawing.Color.White;
            this.maxOutput3.Location = new System.Drawing.Point(319, 314);
            this.maxOutput3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.maxOutput3.Name = "maxOutput3";
            this.maxOutput3.Size = new System.Drawing.Size(77, 37);
            this.maxOutput3.TabIndex = 87;
            this.maxOutput3.Text = "max";
            this.maxOutput3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxOutput6
            // 
            this.maxOutput6.AutoSize = true;
            this.maxOutput6.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maxOutput6.ForeColor = System.Drawing.Color.White;
            this.maxOutput6.Location = new System.Drawing.Point(319, 527);
            this.maxOutput6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.maxOutput6.Name = "maxOutput6";
            this.maxOutput6.Size = new System.Drawing.Size(77, 37);
            this.maxOutput6.TabIndex = 90;
            this.maxOutput6.Text = "max";
            this.maxOutput6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxOutput5
            // 
            this.maxOutput5.AutoSize = true;
            this.maxOutput5.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maxOutput5.ForeColor = System.Drawing.Color.White;
            this.maxOutput5.Location = new System.Drawing.Point(319, 456);
            this.maxOutput5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.maxOutput5.Name = "maxOutput5";
            this.maxOutput5.Size = new System.Drawing.Size(77, 37);
            this.maxOutput5.TabIndex = 89;
            this.maxOutput5.Text = "max";
            this.maxOutput5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxOutput7
            // 
            this.maxOutput7.AutoSize = true;
            this.maxOutput7.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maxOutput7.ForeColor = System.Drawing.Color.White;
            this.maxOutput7.Location = new System.Drawing.Point(319, 598);
            this.maxOutput7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.maxOutput7.Name = "maxOutput7";
            this.maxOutput7.Size = new System.Drawing.Size(77, 37);
            this.maxOutput7.TabIndex = 91;
            this.maxOutput7.Text = "max";
            this.maxOutput7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minOutput7
            // 
            this.minOutput7.AutoSize = true;
            this.minOutput7.BackColor = System.Drawing.Color.Transparent;
            this.minOutput7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minOutput7.ForeColor = System.Drawing.Color.White;
            this.minOutput7.Location = new System.Drawing.Point(408, 598);
            this.minOutput7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.minOutput7.Name = "minOutput7";
            this.minOutput7.Size = new System.Drawing.Size(77, 37);
            this.minOutput7.TabIndex = 97;
            this.minOutput7.Text = "max";
            this.minOutput7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minOutput6
            // 
            this.minOutput6.AutoSize = true;
            this.minOutput6.BackColor = System.Drawing.Color.Transparent;
            this.minOutput6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minOutput6.ForeColor = System.Drawing.Color.White;
            this.minOutput6.Location = new System.Drawing.Point(408, 527);
            this.minOutput6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.minOutput6.Name = "minOutput6";
            this.minOutput6.Size = new System.Drawing.Size(77, 37);
            this.minOutput6.TabIndex = 96;
            this.minOutput6.Text = "max";
            this.minOutput6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minOutput5
            // 
            this.minOutput5.AutoSize = true;
            this.minOutput5.BackColor = System.Drawing.Color.Transparent;
            this.minOutput5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minOutput5.ForeColor = System.Drawing.Color.White;
            this.minOutput5.Location = new System.Drawing.Point(408, 456);
            this.minOutput5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.minOutput5.Name = "minOutput5";
            this.minOutput5.Size = new System.Drawing.Size(77, 37);
            this.minOutput5.TabIndex = 95;
            this.minOutput5.Text = "max";
            this.minOutput5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minOutput4
            // 
            this.minOutput4.AutoSize = true;
            this.minOutput4.BackColor = System.Drawing.Color.Transparent;
            this.minOutput4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minOutput4.ForeColor = System.Drawing.Color.White;
            this.minOutput4.Location = new System.Drawing.Point(408, 385);
            this.minOutput4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.minOutput4.Name = "minOutput4";
            this.minOutput4.Size = new System.Drawing.Size(77, 37);
            this.minOutput4.TabIndex = 94;
            this.minOutput4.Text = "max";
            this.minOutput4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minOutput3
            // 
            this.minOutput3.AutoSize = true;
            this.minOutput3.BackColor = System.Drawing.Color.Transparent;
            this.minOutput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minOutput3.ForeColor = System.Drawing.Color.White;
            this.minOutput3.Location = new System.Drawing.Point(408, 314);
            this.minOutput3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.minOutput3.Name = "minOutput3";
            this.minOutput3.Size = new System.Drawing.Size(77, 37);
            this.minOutput3.TabIndex = 93;
            this.minOutput3.Text = "max";
            this.minOutput3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minOutput2
            // 
            this.minOutput2.AutoSize = true;
            this.minOutput2.BackColor = System.Drawing.Color.Transparent;
            this.minOutput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minOutput2.ForeColor = System.Drawing.Color.White;
            this.minOutput2.Location = new System.Drawing.Point(408, 243);
            this.minOutput2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.minOutput2.Name = "minOutput2";
            this.minOutput2.Size = new System.Drawing.Size(77, 37);
            this.minOutput2.TabIndex = 92;
            this.minOutput2.Text = "max";
            this.minOutput2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.minOutput7);
            this.Controls.Add(this.minOutput6);
            this.Controls.Add(this.minOutput5);
            this.Controls.Add(this.minOutput4);
            this.Controls.Add(this.minOutput3);
            this.Controls.Add(this.minOutput2);
            this.Controls.Add(this.maxOutput7);
            this.Controls.Add(this.maxOutput6);
            this.Controls.Add(this.maxOutput5);
            this.Controls.Add(this.maxOutput4);
            this.Controls.Add(this.maxOutput3);
            this.Controls.Add(this.maxOutput2);
            this.Controls.Add(this.minOutput1);
            this.Controls.Add(this.maxOutput1);
            this.Controls.Add(this.day7Label);
            this.Controls.Add(this.day6Label);
            this.Controls.Add(this.day5Label);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.day4Label);
            this.Controls.Add(this.day3Label);
            this.Controls.Add(this.day2Label);
            this.Controls.Add(this.day1Label);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.line1Label);
            this.Controls.Add(this.line2Label);
            this.Controls.Add(this.findCityLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.currentLabel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(500, 769);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.weatherIcons_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label findCityLabel;
        private System.Windows.Forms.Label line2Label;
        private System.Windows.Forms.Label line1Label;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label day1Label;
        private System.Windows.Forms.Label day2Label;
        private System.Windows.Forms.Label day3Label;
        private System.Windows.Forms.Label day4Label;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Label day5Label;
        private System.Windows.Forms.Label day6Label;
        private System.Windows.Forms.Label day7Label;
        private System.Windows.Forms.Label maxOutput1;
        private System.Windows.Forms.Label minOutput1;
        private System.Windows.Forms.Label maxOutput2;
        private System.Windows.Forms.Label maxOutput4;
        private System.Windows.Forms.Label maxOutput3;
        private System.Windows.Forms.Label maxOutput6;
        private System.Windows.Forms.Label maxOutput5;
        private System.Windows.Forms.Label maxOutput7;
        private System.Windows.Forms.Label minOutput7;
        private System.Windows.Forms.Label minOutput6;
        private System.Windows.Forms.Label minOutput5;
        private System.Windows.Forms.Label minOutput4;
        private System.Windows.Forms.Label minOutput3;
        private System.Windows.Forms.Label minOutput2;
    }
}
