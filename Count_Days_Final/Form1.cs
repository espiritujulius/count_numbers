namespace Count_Days_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            CalculateDays();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            CalculateDays();
        }
        private void CalculateDays()
        {
            DateTime fromDate = dtpFrom.Value;
            DateTime toDate = dtpTo.Value;

            TimeSpan duration = toDate.Subtract(fromDate);
            int numberOfDays = duration.Days;

            lblCount.Text = numberOfDays.ToString();

            int numberOfMonths = ((toDate.Year - fromDate.Year) * 12) + (toDate.Month - fromDate.Month);

            if (fromDate.Day > toDate.Day)
            {
                numberOfMonths--;
            }


            lblMonth.Text = numberOfMonths.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;
            lblCount.Text = "0";
            lblMonth.Text = "0";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}