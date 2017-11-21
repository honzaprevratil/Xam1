using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xam1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Submit_Clicked(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
            if (checkPalidrom(text))
            {
                ((Entry)sender).Text = "Palidrom";
            } else
            {
                ((Entry)sender).Text = "Obyčejné slovo";
            }
        }

        private bool checkPalidrom(string text)
        {
            string[] chars = text.Split();

            int x = 0;
            foreach (string char1 in chars)
            {
                if (char1 == "c")
                {
                    if (chars[x+1] == "h")
                    {
                        chars[x] = "ch";
                    }
                }
                x++;
            }

            int len = chars.Length;
            for (int i = 0; i < len; i++)
            {
                if (chars[i] == chars[len-i])
                {
                    if (i == len-1)
                    {
                        return true;
                    }
                } else
                {
                    return false;
                }
            };
            return false;
        }
    }
}
