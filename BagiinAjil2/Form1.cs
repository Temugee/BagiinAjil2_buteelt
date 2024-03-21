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
            DateDifferenceDate dateDifferenceDataTwoThousand = new DateDifferenceDate(fromDate2000.Value, toDate2000.Value);
            differenceText.Text = dateDifferenceData.ToString();
            universityText.Text = "1980 оны их сургуульд нийт суралцсан цаг:" + dateDifferenceData.NiitSuraltssanTsagMyangaYsunzuu.ToString();
            universityText2000.Text = "2000 оны их сургуульд нийт суралцсан цаг:" + dateDifferenceData.NiitSuraltssanTsagHoyrMyanga.ToString();
            txtJishih.Text = dateDifferenceData.NiitSuraltssanTsagMyangaYsunzuu.ToString() + dateDifferenceData.jishih + dateDifferenceData.NiitSuraltssanTsagHoyrMyanga.ToString() +
                Environment.NewLine + "Яалгаатай цаг: " +
                (dateDifferenceData.ihBaga == true ? dateDifferenceData.NiitSuraltssanTsagMyangaYsunzuu - dateDifferenceData.NiitSuraltssanTsagHoyrMyanga : dateDifferenceData.NiitSuraltssanTsagHoyrMyanga - dateDifferenceData.NiitSuraltssanTsagMyangaYsunzuu);
            
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

        public double Oyutan;
        public double NiitSuraltssanTsagMyangaYsunzuu;
        public double NiitSuraltssanTsagHoyrMyanga;
        //Тогтмолууд (1980 он)
        public static int NegJiliinHicheellehDolooHonog = 39;
        public static int NegeesGuravDugaarAngiDolooHonogHicheelteiTsag_1980 = 18;
        public static double DuruvuusNaimDugaarAngiDolooHonogHicheelteiTsag_1980 = 25.5;
        public static int YsuusAravDugaarAngiDolooHonogHicheelteiTsag_1980 = 27;
        public static int DeedSurguulDolooHonogHicheelteiTsag_1980 = 27;

        //Тогтмолууд (2000 он)
        public static int NegeesTavDugaarAngiDolooHonogHicheelteiTsag_2000 = 20;
        public static int ZurgaigaasArvanHoyrDugaarAnigiDolooHonogHicheelteiTsag_2000 = 30;
        public static int DeedSurguulDolooHonogHicheelteiTsag_2000 = 15;

        //jishih variable
        public string jishih;
        public bool ihBaga;
        public DateDifferenceDate(DateTime fromDateValue, DateTime toDateValue)
        {
            var difference = toDateValue - fromDateValue;
            Days = (int)difference.TotalDays;
            Minutes = (int)difference.TotalMinutes;
            Seconds = (long)difference.TotalSeconds;
            Hours = (int)difference.TotalHours;
            Years = Days / 365;
            Months = Days / 30;


            //1980 аад оны үеийн бодолт
            NiitSuraltssanTsagMyangaYsunzuu = ((NegeesGuravDugaarAngiDolooHonogHicheelteiTsag_1980 * NegJiliinHicheellehDolooHonog) * 3) +
                ((DuruvuusNaimDugaarAngiDolooHonogHicheelteiTsag_1980 * NegJiliinHicheellehDolooHonog) * 5) +
                ((YsuusAravDugaarAngiDolooHonogHicheelteiTsag_1980 * NegJiliinHicheellehDolooHonog) * 2) +
                ((DeedSurguulDolooHonogHicheelteiTsag_1980 * NegJiliinHicheellehDolooHonog) * 4);
            Oyutan = (DeedSurguulDolooHonogHicheelteiTsag_1980 * NegJiliinHicheellehDolooHonog) * Years;

            //2000 аад оны үеийн бодолт
            NiitSuraltssanTsagHoyrMyanga = ((NegeesTavDugaarAngiDolooHonogHicheelteiTsag_2000 * NegJiliinHicheellehDolooHonog) * 5) +
                ((ZurgaigaasArvanHoyrDugaarAnigiDolooHonogHicheelteiTsag_2000 * NegJiliinHicheellehDolooHonog) * 7) +
                ((DeedSurguulDolooHonogHicheelteiTsag_2000 * NegJiliinHicheellehDolooHonog) * 4);

            if (NiitSuraltssanTsagMyangaYsunzuu > NiitSuraltssanTsagHoyrMyanga)
            {
                jishih = ">";
            }
            else
            {
                jishih = "<";
            }
            if (jishih == ">")
            {
                ihBaga = true;
            }
            else
            {
                ihBaga = false;
            }


        }
        public override string ToString()
        {
            return $"{Years} Жил {Environment.NewLine} {Months} Сар {Environment.NewLine} {Days} Өдөр {Environment.NewLine}" +
                $"{Hours} Цаг {Environment.NewLine} {Minutes} Минут {Environment.NewLine}" +
                $"{Seconds} Секунд {Environment.NewLine}" +
                $"{NiitSuraltssanTsagMyangaYsunzuu} Нийт суралцсан цаг {Environment.NewLine}";
        }

        
    }
}
