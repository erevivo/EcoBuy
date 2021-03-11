using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace EcoBuy.UserControls

{
    public partial class DigitalClock : UserControl
    {
        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();




        public DigitalClock()
        {

            InitializeComponent();
            Temp();
            Timer.Tick += new EventHandler(Timer_Click);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            DateTime d;
            d = DateTime.Now;
            if (d.Minute < 10 && d.Minute >= 0)
                label1.Content = d.Hour + " : " + "0" + d.Minute;
            else
                label1.Content = d.Hour + " : " + d.Minute;
            hedate.Content = d.Date.ToString("dd/MM/yyyy");
        }
        private async void Temp()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://api.openweathermap.org");
            var response = await client.GetAsync($"/data/2.5/weather?q=Ashdod&appid=90f9786ae346b4c7d7d14175a35e4118");

            // This line gives me error
            var stringResult = await response.Content.ReadAsStringAsync();

            var obj = JsonConvert.DeserializeObject<dynamic>(stringResult);
            var tmpDegreesF = Math.Round(((float)obj.main.temp * 9 / 5 - 459.67), 2);
            var tmpDegreesC = ((tmpDegreesF - 32) * (0.55555555556));
            temp.Content = tmpDegreesC.ToString();
        }

    }

}