namespace RentalCar
{
    partial class RentalCar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExitButton = new Button();
            SummaryButton = new Button();
            CalculateButton = new Button();
            ClearButton = new Button();
            SeniorDiscountCheckBox = new CheckBox();
            AAADiscountCheckBox = new CheckBox();
            DiscountGroupBox = new GroupBox();
            KilometersRadioButton = new RadioButton();
            MilesRadioButton = new RadioButton();
            MilesOrKiloGroupBox = new GroupBox();
            CustomerNameTextBox = new TextBox();
            AddressTextBox = new TextBox();
            StateTextBox = new TextBox();
            CityTextBox = new TextBox();
            DaysTextBox = new TextBox();
            EOdometerReadTextBox = new TextBox();
            BOdometerTextBox = new TextBox();
            ZipCodeTextBox = new TextBox();
            CustomerNameLabel = new Label();
            AddressLabel = new Label();
            StateLabel = new Label();
            CityLabel = new Label();
            DaysLabel = new Label();
            EOdometerReadingLabel = new Label();
            BOdometerReadLabel = new Label();
            ZipCodeLabel = new Label();
            OwedLabel = new Label();
            DiscountLabel = new Label();
            DailyChargeLabel = new Label();
            MilageLabel = new Label();
            DistanceLabel = new Label();
            AmountOwedTextBox = new TextBox();
            DiscountTextBox = new TextBox();
            DayChargeTextBox = new TextBox();
            MilageChargeTextBox = new TextBox();
            DistanceTextBox = new TextBox();
            DiscountGroupBox.SuspendLayout();
            MilesOrKiloGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(584, 361);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(148, 48);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SummaryButton
            // 
            SummaryButton.Location = new Point(420, 361);
            SummaryButton.Name = "SummaryButton";
            SummaryButton.Size = new Size(148, 48);
            SummaryButton.TabIndex = 3;
            SummaryButton.Text = "&Summary";
            SummaryButton.UseVisualStyleBackColor = true;
            SummaryButton.Click += SummaryButton_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(91, 361);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(148, 48);
            CalculateButton.TabIndex = 1;
            CalculateButton.Text = "&Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(255, 361);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(148, 48);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SeniorDiscountCheckBox
            // 
            SeniorDiscountCheckBox.AutoSize = true;
            SeniorDiscountCheckBox.Location = new Point(46, 16);
            SeniorDiscountCheckBox.Name = "SeniorDiscountCheckBox";
            SeniorDiscountCheckBox.Size = new Size(129, 21);
            SeniorDiscountCheckBox.TabIndex = 5;
            SeniorDiscountCheckBox.Text = "Senior Discount";
            SeniorDiscountCheckBox.UseVisualStyleBackColor = true;
            // 
            // AAADiscountCheckBox
            // 
            AAADiscountCheckBox.AutoSize = true;
            AAADiscountCheckBox.Location = new Point(46, 43);
            AAADiscountCheckBox.Name = "AAADiscountCheckBox";
            AAADiscountCheckBox.Size = new Size(116, 21);
            AAADiscountCheckBox.TabIndex = 6;
            AAADiscountCheckBox.Text = "AAA Discount";
            AAADiscountCheckBox.UseVisualStyleBackColor = true;
            // 
            // DiscountGroupBox
            // 
            DiscountGroupBox.Controls.Add(AAADiscountCheckBox);
            DiscountGroupBox.Controls.Add(SeniorDiscountCheckBox);
            DiscountGroupBox.Location = new Point(485, 269);
            DiscountGroupBox.Name = "DiscountGroupBox";
            DiscountGroupBox.Size = new Size(247, 86);
            DiscountGroupBox.TabIndex = 7;
            DiscountGroupBox.TabStop = false;
            DiscountGroupBox.Text = "Discounts";
            // 
            // KilometersRadioButton
            // 
            KilometersRadioButton.AutoSize = true;
            KilometersRadioButton.Location = new Point(52, 16);
            KilometersRadioButton.Name = "KilometersRadioButton";
            KilometersRadioButton.Size = new Size(97, 21);
            KilometersRadioButton.TabIndex = 8;
            KilometersRadioButton.TabStop = true;
            KilometersRadioButton.Text = "Kilometers";
            KilometersRadioButton.UseVisualStyleBackColor = true;
            // 
            // MilesRadioButton
            // 
            MilesRadioButton.AutoSize = true;
            MilesRadioButton.Location = new Point(52, 43);
            MilesRadioButton.Name = "MilesRadioButton";
            MilesRadioButton.Size = new Size(62, 21);
            MilesRadioButton.TabIndex = 9;
            MilesRadioButton.TabStop = true;
            MilesRadioButton.Text = "Miles";
            MilesRadioButton.UseVisualStyleBackColor = true;
            // 
            // MilesOrKiloGroupBox
            // 
            MilesOrKiloGroupBox.Controls.Add(MilesRadioButton);
            MilesOrKiloGroupBox.Controls.Add(KilometersRadioButton);
            MilesOrKiloGroupBox.Location = new Point(91, 269);
            MilesOrKiloGroupBox.Name = "MilesOrKiloGroupBox";
            MilesOrKiloGroupBox.Size = new Size(316, 86);
            MilesOrKiloGroupBox.TabIndex = 10;
            MilesOrKiloGroupBox.TabStop = false;
            MilesOrKiloGroupBox.Text = "Is this in miles or kilometers?";
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new Point(146, 22);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(212, 25);
            CustomerNameTextBox.TabIndex = 11;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(91, 53);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(267, 25);
            AddressTextBox.TabIndex = 12;
            // 
            // StateTextBox
            // 
            StateTextBox.Location = new Point(91, 115);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(267, 25);
            StateTextBox.TabIndex = 14;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(72, 84);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(286, 25);
            CityTextBox.TabIndex = 13;
            // 
            // DaysTextBox
            // 
            DaysTextBox.Location = new Point(148, 239);
            DaysTextBox.Name = "DaysTextBox";
            DaysTextBox.Size = new Size(210, 25);
            DaysTextBox.TabIndex = 18;
            // 
            // EOdometerReadTextBox
            // 
            EOdometerReadTextBox.Location = new Point(191, 208);
            EOdometerReadTextBox.Name = "EOdometerReadTextBox";
            EOdometerReadTextBox.Size = new Size(167, 25);
            EOdometerReadTextBox.TabIndex = 17;
            // 
            // BOdometerTextBox
            // 
            BOdometerTextBox.Location = new Point(226, 177);
            BOdometerTextBox.Name = "BOdometerTextBox";
            BOdometerTextBox.Size = new Size(132, 25);
            BOdometerTextBox.TabIndex = 16;
            // 
            // ZipCodeTextBox
            // 
            ZipCodeTextBox.Location = new Point(101, 146);
            ZipCodeTextBox.Name = "ZipCodeTextBox";
            ZipCodeTextBox.Size = new Size(257, 25);
            ZipCodeTextBox.TabIndex = 15;
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Location = new Point(33, 25);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(107, 17);
            CustomerNameLabel.TabIndex = 19;
            CustomerNameLabel.Text = "Customer Name";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(33, 56);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(58, 17);
            AddressLabel.TabIndex = 20;
            AddressLabel.Text = "Address";
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(33, 118);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(39, 17);
            StateLabel.TabIndex = 22;
            StateLabel.Text = "State";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(33, 87);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(33, 17);
            CityLabel.TabIndex = 21;
            CityLabel.Text = "City";
            // 
            // DaysLabel
            // 
            DaysLabel.AutoSize = true;
            DaysLabel.Location = new Point(33, 242);
            DaysLabel.Name = "DaysLabel";
            DaysLabel.Size = new Size(109, 17);
            DaysLabel.TabIndex = 26;
            DaysLabel.Text = "Number of Days";
            // 
            // EOdometerReadingLabel
            // 
            EOdometerReadingLabel.AutoSize = true;
            EOdometerReadingLabel.Location = new Point(33, 211);
            EOdometerReadingLabel.Name = "EOdometerReadingLabel";
            EOdometerReadingLabel.Size = new Size(152, 17);
            EOdometerReadingLabel.TabIndex = 25;
            EOdometerReadingLabel.Text = "End Odometer Reading";
            // 
            // BOdometerReadLabel
            // 
            BOdometerReadLabel.AutoSize = true;
            BOdometerReadLabel.Location = new Point(33, 180);
            BOdometerReadLabel.Name = "BOdometerReadLabel";
            BOdometerReadLabel.Size = new Size(189, 17);
            BOdometerReadLabel.TabIndex = 24;
            BOdometerReadLabel.Text = "Beginning Odometer Reading";
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Location = new Point(33, 149);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(62, 17);
            ZipCodeLabel.TabIndex = 23;
            ZipCodeLabel.Text = "Zip Code";
            // 
            // OwedLabel
            // 
            OwedLabel.AutoSize = true;
            OwedLabel.Location = new Point(429, 150);
            OwedLabel.Name = "OwedLabel";
            OwedLabel.Size = new Size(98, 17);
            OwedLabel.TabIndex = 36;
            OwedLabel.Text = "Amount Owed";
            // 
            // DiscountLabel
            // 
            DiscountLabel.AutoSize = true;
            DiscountLabel.Location = new Point(429, 119);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(105, 17);
            DiscountLabel.TabIndex = 35;
            DiscountLabel.Text = "Minus Discount";
            // 
            // DailyChargeLabel
            // 
            DailyChargeLabel.AutoSize = true;
            DailyChargeLabel.Location = new Point(429, 88);
            DailyChargeLabel.Name = "DailyChargeLabel";
            DailyChargeLabel.Size = new Size(87, 17);
            DailyChargeLabel.TabIndex = 34;
            DailyChargeLabel.Text = "Daily Charge";
            // 
            // MilageLabel
            // 
            MilageLabel.AutoSize = true;
            MilageLabel.Location = new Point(429, 57);
            MilageLabel.Name = "MilageLabel";
            MilageLabel.Size = new Size(95, 17);
            MilageLabel.TabIndex = 33;
            MilageLabel.Text = "Milage Charge";
            // 
            // DistanceLabel
            // 
            DistanceLabel.AutoSize = true;
            DistanceLabel.Location = new Point(429, 26);
            DistanceLabel.Name = "DistanceLabel";
            DistanceLabel.Size = new Size(113, 17);
            DistanceLabel.TabIndex = 32;
            DistanceLabel.Text = "Distance in Miles";
            // 
            // AmountOwedTextBox
            // 
            AmountOwedTextBox.Location = new Point(530, 147);
            AmountOwedTextBox.Name = "AmountOwedTextBox";
            AmountOwedTextBox.Size = new Size(223, 25);
            AmountOwedTextBox.TabIndex = 31;
            // 
            // DiscountTextBox
            // 
            DiscountTextBox.Location = new Point(540, 116);
            DiscountTextBox.Name = "DiscountTextBox";
            DiscountTextBox.Size = new Size(213, 25);
            DiscountTextBox.TabIndex = 30;
            // 
            // DayChargeTextBox
            // 
            DayChargeTextBox.Location = new Point(541, 85);
            DayChargeTextBox.Name = "DayChargeTextBox";
            DayChargeTextBox.Size = new Size(213, 25);
            DayChargeTextBox.TabIndex = 29;
            // 
            // MilageChargeTextBox
            // 
            MilageChargeTextBox.Location = new Point(530, 53);
            MilageChargeTextBox.Name = "MilageChargeTextBox";
            MilageChargeTextBox.Size = new Size(223, 25);
            MilageChargeTextBox.TabIndex = 28;
            // 
            // DistanceTextBox
            // 
            DistanceTextBox.Location = new Point(541, 22);
            DistanceTextBox.Name = "DistanceTextBox";
            DistanceTextBox.Size = new Size(212, 25);
            DistanceTextBox.TabIndex = 27;
            // 
            // RentalCar
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 414);
            Controls.Add(OwedLabel);
            Controls.Add(DiscountLabel);
            Controls.Add(DailyChargeLabel);
            Controls.Add(MilageLabel);
            Controls.Add(DistanceLabel);
            Controls.Add(AmountOwedTextBox);
            Controls.Add(DiscountTextBox);
            Controls.Add(DayChargeTextBox);
            Controls.Add(MilageChargeTextBox);
            Controls.Add(DistanceTextBox);
            Controls.Add(DaysLabel);
            Controls.Add(EOdometerReadingLabel);
            Controls.Add(BOdometerReadLabel);
            Controls.Add(ZipCodeLabel);
            Controls.Add(StateLabel);
            Controls.Add(CityLabel);
            Controls.Add(AddressLabel);
            Controls.Add(CustomerNameLabel);
            Controls.Add(DaysTextBox);
            Controls.Add(EOdometerReadTextBox);
            Controls.Add(BOdometerTextBox);
            Controls.Add(ZipCodeTextBox);
            Controls.Add(StateTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(AddressTextBox);
            Controls.Add(CustomerNameTextBox);
            Controls.Add(MilesOrKiloGroupBox);
            Controls.Add(DiscountGroupBox);
            Controls.Add(CalculateButton);
            Controls.Add(ClearButton);
            Controls.Add(SummaryButton);
            Controls.Add(ExitButton);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "RentalCar";
            Text = "Car Rental";
            Load += RentalCar_Load;
            DiscountGroupBox.ResumeLayout(false);
            DiscountGroupBox.PerformLayout();
            MilesOrKiloGroupBox.ResumeLayout(false);
            MilesOrKiloGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private Button SummaryButton;
        private Button CalculateButton;
        private Button ClearButton;
        private CheckBox SeniorDiscountCheckBox;
        private CheckBox AAADiscountCheckBox;
        private GroupBox DiscountGroupBox;
        private RadioButton KilometersRadioButton;
        private RadioButton MilesRadioButton;
        private GroupBox MilesOrKiloGroupBox;
        private TextBox CustomerNameTextBox;
        private TextBox AddressTextBox;
        private TextBox StateTextBox;
        private TextBox CityTextBox;
        private TextBox DaysTextBox;
        private TextBox EOdometerReadTextBox;
        private TextBox BOdometerTextBox;
        private TextBox ZipCodeTextBox;
        private Label CustomerNameLabel;
        private Label AddressLabel;
        private Label StateLabel;
        private Label CityLabel;
        private Label DaysLabel;
        private Label EOdometerReadingLabel;
        private Label BOdometerReadLabel;
        private Label ZipCodeLabel;
        private Label OwedLabel;
        private Label DiscountLabel;
        private Label DailyChargeLabel;
        private Label MilageLabel;
        private Label DistanceLabel;
        private TextBox AmountOwedTextBox;
        private TextBox DiscountTextBox;
        private TextBox DayChargeTextBox;
        private TextBox MilageChargeTextBox;
        private TextBox DistanceTextBox;
    }
}
