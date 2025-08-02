using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCTXAB001_W1
{
    internal class July
    {
        List<Horse> horses;


        public July()
        {
           horses = new List<Horse>();
        }

        public void addHorse(Horse newHorse)
        {
            horses.Add(newHorse);
        }

        public void DisplayRoster(TextBox display)
        {
            if (horses.Count == 1)
            {
                  string border = new string('=', 70);
                  string cent = new string(' ', 50);
                  display.Text += border + Environment.NewLine; 
                  display.Text += cent + "Roster for next race" + Environment.NewLine;
                  display.Text += border + Environment.NewLine + Environment.NewLine;

            }
            //for (int i = 0; i < horses.Count; i++)
            //{
            display.Text += horses[horses.Count-1].HorseDetails() + Environment.NewLine;
            //}

        }

        public Horse Favourite()
        {
            Horse fav = horses[0];

            for (int i = 1; i < horses.Count; i++)
            {
                if (horses[i].AverageTime() < fav.AverageTime())
                {
                    fav = horses[i];
                }
            }

            return fav;
        }

    }
}
