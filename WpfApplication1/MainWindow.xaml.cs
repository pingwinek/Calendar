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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Calendar();
            GetData(DateTime.Now.Month, DateTime.Now.Day);
        }

        void Calendar()
        {
            txt1.Text = DateTime.Now.DayOfWeek.ToString();
            monthtxt.Text = DateTime.Now.Month.ToString();
            daytxt.Text = DateTime.Now.Day.ToString();
            datetxt.Text = DateTime.Now.Date.ToShortDateString();
            yeartxt.Text = DateTime.Now.Date.Year.ToString();
        }

        void GetData(int month, int day)
        {
            try
            {
                SqlConnection thisConnection = new SqlConnection(@"Server=(local);Database=EventsToCalendar;Trusted_Connection=Yes;");
                thisConnection.Open();

                string Get_Data = "SELECT EventCal FROM EventsCalendar WHERE Month=month AND Day=day";

                SqlCommand cmd = thisConnection.CreateCommand();
                cmd.CommandText = Get_Data;

                contenttxt.Text = cmd.ExecuteScalar().ToString();
            }
            catch
            {
                MessageBox.Show("db error");
            }
        }
    }
}
