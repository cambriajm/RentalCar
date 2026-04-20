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

        private bool ValidateFields()
        {

        }

         





        private void RentalCar_Load(object sender, EventArgs e)
        {

        }

         
    }
}
