namespace XMLWeather
{
    partial class FindCityScreen
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
            this.findCityLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.line2Label = new System.Windows.Forms.Label();
            this.line1Label = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.countryCodeLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryCodeTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // findCityLabel
            // 
            this.findCityLabel.BackColor = System.Drawing.Color.Transparent;
            this.findCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findCityLabel.ForeColor = System.Drawing.Color.White;
            this.findCityLabel.Location = new System.Drawing.Point(3, 716);
            this.findCityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.findCityLabel.Name = "findCityLabel";
            this.findCityLabel.Size = new System.Drawing.Size(167, 53);
            this.findCityLabel.TabIndex = 55;
            this.findCityLabel.Text = "Find City";
            this.findCityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(333, 716);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(166, 53);
            this.forecastLabel.TabIndex = 53;
            this.forecastLabel.Text = "Forecast";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // currentLabel
            // 
            this.currentLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.currentLabel.ForeColor = System.Drawing.Color.White;
            this.currentLabel.Location = new System.Drawing.Point(165, 716);
            this.currentLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(167, 53);
            this.currentLabel.TabIndex = 52;
            this.currentLabel.Text = "Current";
            this.currentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.currentLabel.Click += new System.EventHandler(this.currentLabel_Click);
            // 
            // cityLabel
            // 
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(32, 115);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(141, 44);
            this.cityLabel.TabIndex = 45;
            this.cityLabel.Text = "City";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(264, 220);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(44, 25);
            this.currentOutput.TabIndex = 47;
            // 
            // line2Label
            // 
            this.line2Label.BackColor = System.Drawing.Color.Transparent;
            this.line2Label.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line2Label.ForeColor = System.Drawing.Color.White;
            this.line2Label.Location = new System.Drawing.Point(0, 661);
            this.line2Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.line2Label.Name = "line2Label";
            this.line2Label.Size = new System.Drawing.Size(500, 55);
            this.line2Label.TabIndex = 54;
            this.line2Label.Text = "____________________________";
            this.line2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // line1Label
            // 
            this.line1Label.BackColor = System.Drawing.Color.Transparent;
            this.line1Label.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line1Label.ForeColor = System.Drawing.Color.White;
            this.line1Label.Location = new System.Drawing.Point(6, 18);
            this.line1Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.line1Label.Name = "line1Label";
            this.line1Label.Size = new System.Drawing.Size(500, 52);
            this.line1Label.TabIndex = 56;
            this.line1Label.Text = "____________________________";
            this.line1Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(1, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(499, 53);
            this.titleLabel.TabIndex = 75;
            this.titleLabel.Text = "World Wide Weather";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countryCodeLabel
            // 
            this.countryCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.countryCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.countryCodeLabel.ForeColor = System.Drawing.Color.White;
            this.countryCodeLabel.Location = new System.Drawing.Point(32, 180);
            this.countryCodeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.countryCodeLabel.Name = "countryCodeLabel";
            this.countryCodeLabel.Size = new System.Drawing.Size(220, 44);
            this.countryCodeLabel.TabIndex = 76;
            this.countryCodeLabel.Text = "Country Code";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(299, 121);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(168, 31);
            this.cityTextBox.TabIndex = 77;
            // 
            // countryCodeTextBox
            // 
            this.countryCodeTextBox.Location = new System.Drawing.Point(299, 186);
            this.countryCodeTextBox.Name = "countryCodeTextBox";
            this.countryCodeTextBox.Size = new System.Drawing.Size(168, 31);
            this.countryCodeTextBox.TabIndex = 78;
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.Silver;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(139, 281);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(220, 44);
            this.searchLabel.TabIndex = 79;
            this.searchLabel.Text = "Search";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(31, 661);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(448, 44);
            this.errorLabel.TabIndex = 80;
            this.errorLabel.Text = "Sorry, we could not find your location";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // FindCityScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.countryCodeTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.countryCodeLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.findCityLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.line2Label);
            this.Controls.Add(this.line1Label);
            this.Name = "FindCityScreen";
            this.Size = new System.Drawing.Size(500, 769);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label findCityLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label line2Label;
        private System.Windows.Forms.Label line1Label;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label countryCodeLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryCodeTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}
