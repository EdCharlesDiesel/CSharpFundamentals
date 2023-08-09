namespace _03_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DateTime class
            DateTime dateTime = DateTime.UtcNow;
            DateTime dateTimeUnivesarl = DateTime.Now;
            System.Diagnostics.Debug.WriteLine($"Date time {dateTime}");

            //TimeSpan
            TimeSpan timeSpan = new TimeSpan(1,1, 2, 0);
            System.Diagnostics.Debug.WriteLine($"Hours contained {timeSpan.TotalHours}");

            // Formatting Strings
            System.Diagnostics.Debug.WriteLine($"Date time formating {dateTime.ToString("MM-dd-yy")}");
            System.Diagnostics.Debug.WriteLine($"Date time formating full {dateTime.ToString("dddd-dd-MMMM-yyyy HH:mm:ss")}");
            System.Diagnostics.Debug.WriteLine($"Date time formating AM/PM {dateTime.ToString("dddd-dd-MMMM-yyyy hh:mm:tt")}");
            System.Diagnostics.Debug.WriteLine($"Date time universal {dateTimeUnivesarl.ToString("dddd-dd-MMMM-yyyy hh:mm:tt")}");
            System.Diagnostics.Debug.WriteLine($"Date time kind {dateTimeUnivesarl.Kind}");
        }
    }
}