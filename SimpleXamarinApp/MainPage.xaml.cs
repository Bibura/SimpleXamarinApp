using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApp;

namespace SimpleXamarinApp
{
    public partial class MainPage : ContentPage
    {
        List<Report> reports = new List<Report>();
        public MainPage()
        {
            InitializeComponent();
            for (int i = 1; i < 32; i++)
            {
                reports.Add(new Report(i, "Cloudy", new DateTime(2023, 03, i)));
            }
        }
        private void Entry_Completed(object sender, EventArgs e)
        {
            var text = ((Entry)sender).Text;
            foreach (var item in reports)
            {
                if (item.uid.ToString() == text)
                {
                    CounterLabel.Text = item.uid.ToString() + " | " + item.report + " | " + item.date.ToString();
                }
            }
        }
    }
}
