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
            string text = (Entry1.Text).Replace(" ","");
            if (checkPalidrom(text))
            {
                Label1.Text = "Palidrom";
            } else
            {
                Label1.Text = "Obyčejné slovo";
            }
        }

        private bool checkPalidrom(string text)
        {
            List<string> chars = new List<string>();
            int y = 0;
            foreach (char char1 in text)
            {
                chars.Add(text[y].ToString());
                y++;
            }
            
            for (int x = 0; x < chars.Count; x++)
            {
                if (chars[x].ToLower() == "c" && x < chars.Count)
                {
                    if (chars[x+1].ToLower() == "h")
                    {
                        chars[x] = "ch";
                        chars.RemoveAt(x+1);
                    }
                }
            }

            for (int i = 0; i < chars.Count; i++)
            {
                if ( (chars[i].ToLower()) == (chars[chars.Count-1 - i].ToLower()) )
                {
                    if (i == chars.Count - 1)
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
