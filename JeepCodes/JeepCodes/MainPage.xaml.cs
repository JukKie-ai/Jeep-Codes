using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JeepCodes {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        string[] jeep = new string[] { "01A", "02B", "03C", "04A", "04D", "06B", "06D", "10C", "10H", "11A", "11B", "20A", "20C", "42C", "42D" };
        
        string[] routes = new string[] {
            "alpha, bravo, charlie, echo, golf",
            "alpha, charlie, delta, foxtrot, golf",
            "charlie, delta, foxtrot, hotel, india",
            "charlie, delta, echo, foxtrot, golf",
            "charlie, echo, foxtrot, golf, india",
            "delta, hotel, juliet, kilo, lima",
            "delta, foxtrot, golf, india, kilo",
            "foxtrot, golf, hotel, india, juliet",
            "foxtrot, hotel, juliet, lima, november",
            "foxtrot, golf, kilo, mike, november",
            "foxtrot, golf, lima, oscar, papa",
            "india, juliet, november, papa, romeo",
            "india, kilo, lima, mike, romeo",
            "juliet, kilo, lima, mike, oscar",
            "juliet, november, oscar, quebec, romeo",
        };




        private void entJeepCode(object sender, EventArgs e) {


            string compare = ((Entry)sender).Text;

            bool val1 = jeep.Any(compare.Contains);

            for(int i = 0; i < routes.Length; i++) {
                if (jeep[i] == compare && val1 == true) {
                    resultVal.Text = routes[i];
                    break;
                } else {
                    resultVal.Text = "Error";
                }
            }
        }
    }
}
