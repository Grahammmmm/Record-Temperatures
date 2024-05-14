using System.Diagnostics.Eventing.Reader;

namespace Record_Temperatures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // These two lines of code establish the arrays for the total temperature of every day in each month.//
        int[] highTemps = new int[12];
        int[] lowTemps = new int[12];
        // These arrays hold the monthly records for daily high and low temperature.
        int[] highMonthRecords = [16, 17, 21, 24, 28, 31, 32, 32, 31, 25, 20, 18];
        int[] lowMonthRecords = [-11, -8, -5, 2, 6, 10, 12, 12, 8, 1, -3, -8];
        // These arrays hold the monthly records for daily high and low temperatures.
        int[] highDayRecords = [26, 26, 31, 32, 33, 37, 37, 36, 36, 32, 28, 25];
        int[] lowDayRecords = [-28, -20, -18, -9, -5, 0, 6, 4, -2, -10, -16, -24];
        private void button1_Click(object sender, EventArgs e)
        {
            // This converts the user input to useable integers//
            int month = Convert.ToInt32(textBox4.Text);
            int dailyLow = Convert.ToInt32(textBox1.Text);
            int dailyHigh = Convert.ToInt32(textBox2.Text);
            


            if (dailyLow < lowDayRecords[month-1])
            {

                label5.Text = string.Format("This daily temperature is a record! Today's temperature of {0} degrees is less than the record low of {1} degrees!", dailyLow, lowDayRecords[month - 1]);

            }


            else if (dailyHigh > highDayRecords[month - 1])
            {
                label5.Text = string.Format("This daily high temperature is a record! Today's high temperature of {0} degrees is hotter than the previous record of {1} degrees.", dailyHigh, highDayRecords[month - 1]);
            }
            else
            {
                label5.Text = string.Format("Today's temperatures are not a record :(");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt32(textBox4.Text);
            int dailyLow = Convert.ToInt32(textBox1.Text);
            int dailyHigh = Convert.ToInt32(textBox2.Text);
            highTemps[month - 1] += dailyHigh;
            lowTemps[month - 1] += dailyLow;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt32(textBox4.Text);
            int averageLow;
            int averageHigh;

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month ==12)
            {
                averageHigh = (highTemps[month - 1]) / 31;
                averageLow = (lowTemps[month - 1]) / 31;
            }
            else if (month == 4 || month == 6 || month == 9 || month ==11)
            {
                averageHigh = (highTemps[month - 1]) / 30;
                averageLow = (lowTemps[month - 1]) / 30;
            }
            else
            {
                averageHigh = (highTemps[month - 1]) / 28;
                averageLow = (lowTemps[month - 1]) / 28;
            }

           

            if (averageLow < lowMonthRecords[month-1])
            {

                label6.Text = string.Format("This month's average temperature is a record! This month's average temperature of {0} degrees is less than the record average low of {1} degrees!", averageLow, lowMonthRecords[month - 1]);

            }


            else if (averageHigh > highMonthRecords[month - 1])
            {
                label6.Text = string.Format("This month's average high temperature is a record! This month's average high temperature of {0} degrees is hotter than the previous record average high of {1} degrees.", averageHigh, highMonthRecords[month - 1]);
            }
            else
            {
                label6.Text = string.Format("This month's average temperatures are not a record :(");
            }
        }
    }
}
