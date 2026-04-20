namespace RentalCar
{
    public partial class RentalCar : Form
    {
        public RentalCar()
        {
            InitializeComponent();
            SetDefaults();
        }

        int customerTotal = 0;
        decimal milesTotal = 0;
        decimal totalPay = 0;
        decimal miles = 0;
        decimal amountDue = 0;
        void SetDefaults()
        {
            miles = 0;
            amountDue = 0;
            CustomerNameTextBox.Text = "";
            CustomerNameTextBox.BackColor = Color.LightBlue;
            AddressTextBox.Text = "";
            AddressTextBox.BackColor = Color.LightBlue;
            CityTextBox.Text = "";
            CityTextBox.BackColor = Color.LightBlue;
            StateTextBox.Text = "";
            StateTextBox.BackColor = Color.LightBlue;
            ZipCodeTextBox.Text = "";
            ZipCodeTextBox.BackColor = Color.LightBlue;
            BOdometerTextBox.Text = "";
            BOdometerTextBox.BackColor = Color.LightBlue;
            EOdometerReadTextBox.Text = "";
            EOdometerReadTextBox.BackColor = Color.LightBlue;
            DaysTextBox.Text = "";
            DaysTextBox.BackColor = Color.LightBlue;
            DistanceTextBox.Text = "";
            DistanceTextBox.BackColor = Color.LightBlue;
            MilageChargeTextBox.Text = "";
            MilageChargeTextBox.BackColor = Color.LightBlue;
            DayChargeTextBox.Text = "";
            DayChargeTextBox.BackColor = Color.LightBlue;
            DiscountTextBox.Text = "";
            DiscountTextBox.BackColor = Color.LightBlue;
            AmountOwedTextBox.Text = "";
            AmountOwedTextBox.BackColor = Color.LightBlue;
            SummaryButton.Enabled = false;
            MilesRadioButton.Checked = true;
            AAADiscountCheckBox.Checked = true;
            SeniorDiscountCheckBox.Checked = true;
            
            if (customerTotal >=0)
            {
                SummaryButton.Enabled = true;
            }

        }

        private bool Message()
        {
            bool valid = true;
            string message = "";
            if (CustomerNameTextBox.Text == "")
            {
                message += "Please enter your name.\n";
            }
            if (AddressTextBox.Text == "")
            {
                message += "Please enter your address.\n";
            }
            if (CityTextBox.Text == "")
            {
                message += "Please enter your city.\n";
            }
            if (StateTextBox.Text == "")
            {
                message += "Please enter your state.\n";
            }
            if (ZipCodeTextBox.Text == "")
            {
                message += "Please enter your zip code.\n";
            }
            try
            {
                if (int.Parse(BOdometerTextBox.Text) < 0 || int.Parse(BOdometerTextBox.Text) > (int.Parse(EOdometerReadTextBox.Text)))
                {
                    message += "Please enter Odometer reading.\n";
                }
            }
            catch (Exception)
            {
                message += "Please enter Odometer reading.\n";
            }
            try
            {
                if ((int.Parse(EOdometerReadTextBox.Text)<0))
                {
                    message += "Please enter end Odometer reading.\n";
                }
            }
            catch (Exception)
            {
                message += "Please enter end Odometer reading.\n";
            }
            try
            {
                if (int.Parse(DaysTextBox.Text)<0||int.Parse(DaysTextBox.Text)>45)
                {
                    message += "Please enter the number of days (0-45).\n";
                }
            }
            catch (Exception)
            {
                message += "Please enter the number of days (0-45).\n";
            }
            if (message != "")
            {
                MessageBox.Show(message);
            }
            return valid;
        }

        private bool ValidateFields()
        {
            bool valid = true;
            if (CustomerNameTextBox.Text != "") 
            {
                CustomerNameTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                CustomerNameTextBox.BackColor = Color.LightYellow;
                valid = false;
            }
            if (AddressTextBox.Text != "")
            {
                AddressTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                AddressTextBox.BackColor = Color.LightYellow;
                valid = false;
            }
            if (CityTextBox.Text != "")
            {
                CityTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                CityTextBox.BackColor = Color.LightYellow;
                valid = false;
            }
            if (StateTextBox.Text != "")
            {
                StateTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                StateTextBox.BackColor = Color.LightYellow;
                valid = false;
            }
            if (ZipCodeTextBox.Text != "")
            {
                ZipCodeTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                ZipCodeTextBox.BackColor = Color.LightYellow;
                valid = false;
            }
            try
            {
                if (int.Parse(BOdometerTextBox.Text) >= 0 && int.Parse(BOdometerTextBox.Text) < (int.Parse(EOdometerReadTextBox.Text)))
                {
                    BOdometerTextBox.BackColor = Color.LightGreen;
                }
                else
                {
                    BOdometerTextBox.BackColor = Color.LightYellow;
                    valid = false;
                }
            }
            catch (Exception)
            {
                BOdometerTextBox.BackColor = Color.LightYellow;
                valid = false;
            }
            try
            {
                if (int.Parse(EOdometerReadTextBox.Text) >= 0)
                {
                    EOdometerReadTextBox.BackColor = Color.LightGreen;
                }
         
                else
                {
                    EOdometerReadTextBox.BackColor = Color.LightYellow;
                    valid = false;
                }
            }
            catch (Exception)
            {
                EOdometerReadTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            try
            {
                if  (int.Parse(DaysTextBox.Text)>=1&&int.Parse(DaysTextBox.Text)<=45)
                {
                    DaysTextBox.BackColor = Color.LightGreen;
                }
                else
                {
                    DaysTextBox.BackColor = Color.LightYellow;
                    valid = false;
                }
            }
            catch (Exception)
            {
                DaysTextBox.BackColor = Color.LightYellow;
                valid = false;
            }
            return valid;
        }


        decimal CalcAAA(decimal anAmount)//calc AAA discount
        {
            decimal discount = 0;
            if (AAADiscountCheckBox.Checked)
            {
                discount = anAmount * 0.5m;
            }
            return discount;
        }

        decimal CalcSenior(decimal anAmount)//calc senior discount
        {
            decimal discount = 0;
            if (SeniorDiscountCheckBox.Checked)
            {
                discount = anAmount * 0.3m;
            }
            return discount;
        }

        private decimal CalcDrivenMiles(decimal Miles)//miles calculated and kilometer conversion
        {
            if (KilometersRadioButton.Checked)
            {
                Miles = (decimal.Parse(EOdometerReadTextBox.Text) - decimal.Parse(BOdometerTextBox.Text)) * 0.61m;
            }
            else if (MilesRadioButton.Checked)
            {
                Miles = Miles = (decimal.Parse(EOdometerReadTextBox.Text) - decimal.Parse(BOdometerTextBox.Text));
            }
            DistanceTextBox.Text = Miles.ToString() + "miles";
            Miles = Miles;
            return Miles;
        }

        private decimal CalcMilageCharge(decimal milageCharge)
        {
            if (miles <= 200)
            {
                milageCharge = 0.00m;
                MilageChargeTextBox.Text = $"{milageCharge:C}";
            }
            if(miles >= 201 && miles >= 500)
            {
                milageCharge = miles * 0.12m;
                MilageChargeTextBox.Text=$"{milageCharge:C}";
            }
            if(miles >= 501)
            {
                milageCharge = miles * 0.1m;
                MilageChargeTextBox.Text=$"{milageCharge:C}"
            }
            return milageCharge;
        }
         





        private void RentalCar_Load(object sender, EventArgs e)
        {

        }

         
    }
}
