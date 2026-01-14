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
        //Stats for the game
        int aiLevel = 10; //How quickly the monster will move
        int aggressive = 0; //Aggressiveness; set to 1 to move faster
        int currentRoom; //Int to know what room the monster is in
        int moveCounter = 0; //How many seconds since the monster last moved

        public Form1()
        {
            Random rand = new Random();
            currentRoom = rand.Next(5, 11); //Picks a random room to spawn the monster in

            InitializeComponent();

            testOutputLabel.Text += "Current Room : " + currentRoom.ToString() + "\n";

        }


        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();

            //Need to come back and add total turns
            if (moveCounter > 10 - aiLevel - aggressive + rand.Next(0,15)) //Math if statement that determines whether or not the monster will move
            {
                
                int actionSelected = rand.Next(1, 4 + aggressive); //Gets action selected, to choose where to move the monster. It can move to different places when aggressive

                if (actionSelected == 1) //The monster will not move if actionSelect picks a 1, to make it move slower
                {
                    moveCounter = 0; //Resets move counter
                }
                else if ((actionSelected == 2 || actionSelected == 3) && currentRoom == 10) //Moves the character to a new room
                {
                    currentRoom = 9;
                }
                else if (actionSelected == 4 && currentRoom == 10)
                {
                    currentRoom = 14;
                }
                else if (actionSelected == 2 && currentRoom == 9)
                {
                    currentRoom = 10;
                }
                else if (actionSelected == 3 && currentRoom == 9)
                {
                    currentRoom = 8;
                }
                else if (actionSelected == 4 && currentRoom ==9)
                {
                    currentRoom = 11;
                }
                else if (actionSelected == 2 && currentRoom == 8)
                {
                    currentRoom = 9;
                }
                else if (actionSelected == 3 && currentRoom == 8)
                {
                    currentRoom = 6;
                }
                else if (actionSelected == 4 && currentRoom == 8)
                {
                    currentRoom = 5;
                }
                else if (actionSelected == 2 && currentRoom == 7)
                {
                    currentRoom = 8;
                }
                else if (actionSelected == 3 && currentRoom == 7)
                {
                    currentRoom = 6;
                }
                else if (actionSelected == 4 && currentRoom == 7)
                {
                    currentRoom = 12;
                }
                else if (actionSelected == 2 && currentRoom == 6)
                {
                    currentRoom = 7;
                }
                else if (actionSelected == 3 && currentRoom == 6)
                {
                    currentRoom = 3;
                }
                else if (actionSelected == 4 && currentRoom ==6)
                {
                    currentRoom = 5;
                }
                else if (actionSelected == 2 && currentRoom == 5)
                {
                    currentRoom = 6;
                }
                else if (actionSelected == 3 && currentRoom == 5)
                {
                    currentRoom = 2;
                }
                else if (actionSelected == 4 && currentRoom == 5)
                {
                    currentRoom = 4;
                }
                else if (actionSelected == 2 && currentRoom == 4)
                {
                    currentRoom = 2;
                }
                else if (actionSelected == 3 && currentRoom == 4)
                {
                    currentRoom = 3;
                }
                else if (actionSelected == 4 && currentRoom == 4)
                {
                    currentRoom = 3;
                }
                else if (actionSelected == 2 && currentRoom == 3)
                {
                    currentRoom = 4;
                }
                else if ((actionSelected == 3 || actionSelected == 4) && currentRoom == 3)
                {
                    currentRoom = 100; //Attack stage 1
                }
                else if (actionSelected== 2 && currentRoom == 2)
                {
                    currentRoom = 5;
                }
                else if (actionSelected == 3 && currentRoom == 2)
                {
                    currentRoom = 4;
                }
                else if (actionSelected == 4 && currentRoom == 2)
                {
                    currentRoom = 100;
                }

                testOutputLabel.Text += "\nMoved to room " + currentRoom.ToString() + "\n";


                moveCounter = 0;
            }
            testOutputLabel.Text += moveCounter;
            moveCounter++; //Adds one second to the move counter if he doesn't move
        }
    }
}
