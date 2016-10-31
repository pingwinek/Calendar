using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int p = 0;
        MovableHolidays movableHoliday = new MovableHolidays();

        public MainWindow()
        {
            InitializeComponent();
            Calendar(p);
            GetData(DateTime.Now.Month, DateTime.Now.Day);
            //btntoday.FontWeight = FontWeights.Bold;
        }

        private void todayClick(object sender, RoutedEventArgs e)
        {
            p = 0;
            Calendar(p);
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(p);
            GetData(answer.Month, answer.Day);

            //btntom.FontWeight = FontWeights.Light;
            //btnyest.FontWeight = FontWeights.Light;
            //btntoday.FontWeight = FontWeights.Bold;
        }

        private void yesterdayClick(object sender, RoutedEventArgs e)
        {
            p--;
            Calendar(p);
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(p);
            GetData(answer.Month, answer.Day);

            //btntom.FontWeight = FontWeights.Light;
            //btnyest.FontWeight = FontWeights.Bold;
            //btntoday.FontWeight = FontWeights.Light;
        }

        private void tomorrowClick(object sender, RoutedEventArgs e)
        {
            p++;
            Calendar(p);
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(p);
            GetData(answer.Month, answer.Day);

            //btntom.FontWeight = FontWeights.Bold;
            //btnyest.FontWeight = FontWeights.Light;
            //btntoday.FontWeight = FontWeights.Light;
        }

        void Calendar(int param)
        {
            //CultureInfo ci = new CultureInfo("pl-PL");
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(param);

            string actualizeMonth = answer.ToString("MMMM");
            string actualize = answer.ToString("dddd");

            monthtxt.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(actualizeMonth);
            txt1.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(actualize);
            daytxt.Text = answer.Day.ToString();
            datetxt.Text = answer.Date.ToShortDateString();
            yeartxt.Text = answer.Date.Year.ToString();

            if (txt1.Text.Equals("Niedziela"))
            {
                daytxt.Foreground = Brushes.Red;
                txt1.Foreground = Brushes.Red;
                monthtxt.Foreground = Brushes.Red;
            }
            else
            {
                daytxt.Foreground = Brushes.Black;
                txt1.Foreground = Brushes.Black;
                monthtxt.Foreground = Brushes.Black;
            }
        }

        void GetData(int month, int day)
        {
            try
            {
                CalendarDataContext dbContext = new CalendarDataContext();
                using (var context = new CalendarDataContext())
                {
                    if(movableHoliday.movableHol(DateTime.Now) != null)
                    {
                        contenttxt.Text = movableHoliday.movableHol(DateTime.Now) + ", " + (from t in context.EventsCalendars
                                                                                     where t.Day == day && t.Month == month
                                                                                     select t.EventCal).FirstOrDefault();
                    }
                    else
                    {
                        contenttxt.Text = movableHoliday.movableHol(DateTime.Now) + (from t in context.EventsCalendars
                                                                                     where t.Day == day && t.Month == month
                                                                                     select t.EventCal).FirstOrDefault();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Błąd połączenia z bazą danych:(((");
            }
        }

    }
}
