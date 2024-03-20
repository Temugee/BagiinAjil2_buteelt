namespace BagiinAjil2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateDifferenceDate dateDifferenceData = new DateDifferenceDate(fromDate.Value, toDate.Value);
            differenceText.Text = dateDifferenceData.ToString();
        }
    }
    public class DateDifferenceDate
    {
        public int Years;
        public int Months;
        public int Days;
        public int Hours;
        public int Minutes;
        public long Seconds;
        public int Week;
        public int Test;
        
        public DateDifferenceDate(DateTime fromDateValue, DateTime toDateValue)
        {
            var difference = toDateValue - fromDateValue;
            Days = (int)difference.TotalDays;
            Minutes = (int)difference.TotalMinutes;
            Seconds = (long)difference.TotalSeconds;
            Hours = (int)difference.TotalHours;
            Years = Days / 365;
            Months = Days / 30;
            Week = Days / 7;
        }
        public override string ToString()
        {
            return $"{Years} Жил {Environment.NewLine} {Months} Сар {Environment.NewLine} {Days} Өдөр {Environment.NewLine}" +
                $"{Hours} Цаг {Environment.NewLine} {Minutes} Минут {Environment.NewLine}" +
                $"{Seconds} Секунд {Environment.NewLine}" +
                $"{Week} 7 хоног";
        }
    }
}
