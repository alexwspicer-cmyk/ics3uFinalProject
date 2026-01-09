using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ics3uFinalProject
{
    //Alex Spicer
    //ICS3U
    //January 2026
    //10 Nights at Teddy's

    public partial class Form1 : Form
    {

        int aiLevel = 1;
        int aggressive = 0;
        int currentRoom;
        int moveCounter = 0;

        public Form1()
        {
            Random rand = new Random();
            currentRoom = rand.Next(0, 6);

            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();

            //Need to come back and add total turns
            if (moveCounter > 10 - aiLevel - aggressive + rand.Next(0,15))
            {
                testOutputLabel.Text += "\nMoved\n";
                moveCounter = 0;
            }
            testOutputLabel.Text += moveCounter;
            moveCounter++;
        }
    }
}
