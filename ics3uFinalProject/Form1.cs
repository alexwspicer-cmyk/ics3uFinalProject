using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ics3uFinalProject
{
    //Alex Spicer
    //ICS3U
    //January 2026
    //10 Nights at Teddy's

    public partial class Form1 : Form
    {
        //Stats for the game
        int aiLevel = 5; //How quickly the monster will move
        int aggressive = 0; //Aggressiveness; set to 1 to move faster
        int currentRoom; //Int to know what room the monster is in
        int moveCounter = 0; //How many seconds since the monster last moved

        int currentPlayerRoom = 1; //Int to know what room the player is viewing

        int gameTime = 12; //In game time from 12am - 6am

        int ventHealth = 10; //Determines the health of the the vent, ventilation error happens at 0 health
        int audioUses = 4; //Gives the player 4 audio uses at the beginning of the game, audio error occurs when you run out

        bool mapToggle = false; //Shows the default room map on false, shows the vent map on true
        bool panelToggle = true; //Shows cams on false, shows maintenance panel on true
        bool blackberryToggle = false; //Opens up the blackberry playbook

        public Form1()
        {
            Random rand = new Random();
            currentRoom = rand.Next(5, 11); //Picks a random room to spawn the monster in

            InitializeComponent();

            testOutputLabel.Text += "Current Room : " + currentRoom.ToString() + "\n";

            timeLabel.Text = gameTime.ToString() + "AM";

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
                else if ((actionSelected == 2 || actionSelected == 3) && currentRoom == 10) //Moves the character to a new room depending on the current room and aggression
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
                    currentRoom = 100;
                }
                else if (actionSelected == 3 && currentRoom == 2)
                {
                    currentRoom = 4;
                }
                else if (actionSelected == 4 && currentRoom == 2)
                {
                    currentRoom = 100;
                }
                else if (actionSelected > 1  && currentRoom == 11)
                {
                    currentRoom = 300;
                }
                else if (actionSelected > 1 && currentRoom == 12)
                {
                    currentRoom = 300;
                }
                else if (actionSelected > 1 && currentRoom == 13)
                {
                    currentRoom = 100;
                }
                else if (actionSelected > 1 && currentRoom == 14)
                {
                    currentRoom = 100;
                }
                else if (actionSelected > 1 && currentRoom == 15)
                {
                    currentRoom = 100;
                }
                else if (actionSelected > 2 && currentRoom == 100)
                {
                    currentRoom = 200;
                }
                else if (actionSelected > 2 && currentRoom == 200)
                {
                    currentRoom = 300;
                }
                else if (actionSelected == 2 && currentRoom == 300)
                {
                    currentRoom = 1;
                }
                else if (actionSelected > 2 && currentRoom == 300)
                {
                    currentRoom = 400;
                }
                else if (actionSelected == 2 && currentRoom == 1)
                {
                    currentRoom = 300;
                }
                else if (actionSelected > 2 && currentRoom ==1)
                {
                    currentRoom = 400;
                }
                else if (actionSelected > 1 && currentRoom == 400)
                {
                    loseGame();
                }



                testOutputLabel.Text += "\nMoved to room " + currentRoom.ToString() + " - Vent Health : " + ventHealth.ToString() + "\n" ;


                moveCounter = 0;
            }
            testOutputLabel.Text += moveCounter;
            moveCounter++; //Adds one second to the move counter if he doesn't move
        }

        private void loseGame()
        {
            testOutputLabel.Text = "\nLost\n";
            gameTimer.Stop();
            ventTimer.Stop();
            aggressionTimer.Stop();
            clockTimer.Stop();
            intervalTimer.Stop();
        }

        private void ventTimer_Tick(object sender, EventArgs e)
        {
            //removes ventHealth every 9 seconds
            ventHealth--;

            if (ventHealth < 0 || ventHealth == 0) //Makes the monster aggressive if there's a ventilation error
            {
                testOutputLabel.Text += "\nVentilation Error\n";
                aggressive = 1;
            }
        }

        private void disableItems() //Disables everything when resetting items
        {
            ventButton.Enabled = false;
            audioResetButton.Enabled = false;

            room1Button.Enabled = false;
            room2Button.Enabled = false;
            room3Button.Enabled = false;
            room4Button.Enabled = false;
            room5Button.Enabled = false;
            room6Button.Enabled = false;
            room7Button.Enabled = false;
            room8Button.Enabled = false;
            room9Button.Enabled = false;
            room10Button.Enabled = false;
            room11Button.Enabled = false;
            room12Button.Enabled = false;
            room13Button.Enabled = false;
            room14Button.Enabled = false;
            room15Button.Enabled = false;

            audioButton.Enabled = false;
            mapToggleButton.Enabled = false;

            panelToggleButton.Enabled = false;
            blackberryToggleButton.Enabled = false;
        }

        private void enableItems() //Enables everything after items are done being reset
        {
            ventButton.Enabled = true;
            audioResetButton.Enabled = true;

            room1Button.Enabled = true;
            room2Button.Enabled = true;
            room3Button.Enabled = true;
            room4Button.Enabled = true;
            room5Button.Enabled = true;
            room6Button.Enabled = true;
            room7Button.Enabled = true;
            room8Button.Enabled = true;
            room9Button.Enabled = true;
            room10Button.Enabled = true;
            room11Button.Enabled = true;
            room12Button.Enabled = true;
            room13Button.Enabled = true;
            room14Button.Enabled = true;
            room15Button.Enabled = true;

            audioButton.Enabled = true;
            mapToggleButton.Enabled = true;

            panelToggleButton.Enabled = true;
            blackberryToggleButton.Enabled = true;
        }
        
        private async void ventButton_Click(object sender, EventArgs e)
        {
            ventButton.Text = "RESETTING";
            disableItems();

            Random rand = new Random();
            int resetTime = rand.Next(5000, 8000); //Random number for reset time

            // Disable other stuff here

            await Task.Delay(resetTime); //Takes between 5 and 8 seconds to reset

            ventButton.Text = "RESET VENTILATION";
            enableItems();

            ventHealth = 10; //Resets the vent health to full
        }

        private void aggressionTimer_Tick(object sender, EventArgs e)
        {
            if (gameTime > 3)
            {
                aggressive = 0; //Resets his aggression every 15 seconds, but stops past 4am making him constantly aggressive
            }
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            //Changes the in game time by an hour every minute

            if (gameTime == 12)
            {
                gameTime = 1;
            }
            else
            {
                gameTime++;
            }

            if (gameTime == 6)
            {
                //Wins the game

                gameTimer.Stop();
                ventTimer.Stop();
                aggressionTimer.Stop();
                clockTimer.Stop();
                intervalTimer.Stop();
            }

            if (gameTime == 4)
            {
                aggressive = 1;
            }

            timeLabel.Text = gameTime.ToString() + "AM";

        }

        private void room1Button_Click(object sender, EventArgs e)
        {
            currentPlayerRoom = 1;
            
            resetColour();
            selectColour(room1Button);
        }

        private void room2Button_Click(object sender, EventArgs e)
        {
            currentPlayerRoom = 2;
            
            resetColour();
            selectColour(room2Button);
        }

        private void room3Button_Click(object sender, EventArgs e)
        {
            currentPlayerRoom = 3;
            
            resetColour();
            selectColour(room3Button);
        }

        private void room4Button_Click(object sender, EventArgs e)
        {
            currentPlayerRoom = 4;
            
            resetColour();
            selectColour(room4Button);
        }

        private void room5Button_Click(object sender, EventArgs e)
        {
            currentPlayerRoom = 5;
            
            resetColour();
            selectColour(room5Button);
        }

        private void room6Button_Click(object sender, EventArgs e)
        {
            currentPlayerRoom = 6;
            
            resetColour();
            selectColour(room6Button);
        }

        private void room7Button_Click(object sender, EventArgs e)
        {
            currentPlayerRoom = 7;
            
            resetColour();
            selectColour(room7Button);
        }

        private void room8Button_Click(object sender, EventArgs e)
        {
            currentPlayerRoom = 8;
            
            resetColour();
            selectColour(room8Button);
        }

        private void room9Button_Click(object sender, EventArgs e)
        {
            currentPlayerRoom = 9;
            
            resetColour();
            selectColour(room9Button);
        }

        private void room10Button_Click(object sender, EventArgs e)
        {
            currentPlayerRoom = 10;
            
            resetColour();
            selectColour(room10Button);
        }

        private void room11Button_Click(object sender, EventArgs e)
        {
            currentPlayerRoom = 11;
            
            resetColour();
            selectColour(room11Button);
        }

        private void room12Button_Click(object sender, EventArgs e)
        {
            currentPlayerRoom = 12;
            
            resetColour();
            selectColour(room12Button);
        }

        private void room13Button_Click(object sender, EventArgs e)
        {
            currentPlayerRoom = 13;
            
            resetColour();
            selectColour(room13Button);
        }

        private void room14Button_Click(object sender, EventArgs e)
        {
            currentPlayerRoom = 14;
            
            resetColour();
            selectColour(room14Button);
        }

        private void room15Button_Click(object sender, EventArgs e)
        {
            currentPlayerRoom = 15;
            
            resetColour();
            selectColour(room15Button);
        }


        private void resetColour()
        {
            //Resets the colours of all of the cameras

            room1Button.BackColor = Color.White;
            room2Button.BackColor = Color.White;
            room3Button.BackColor = Color.White;
            room4Button.BackColor = Color.White;
            room5Button.BackColor = Color.White;
            room6Button.BackColor = Color.White;
            room7Button.BackColor = Color.White;
            room8Button.BackColor = Color.White;
            room9Button.BackColor = Color.White;
            room10Button.BackColor = Color.White;
            room11Button.BackColor = Color.White;
            room12Button.BackColor = Color.White;
            room13Button.BackColor = Color.White;
            room14Button.BackColor = Color.White;
            room15Button.BackColor = Color.White;

            room1Button.ForeColor = Color.Black;
            room2Button.ForeColor = Color.Black;
            room3Button.ForeColor = Color.Black;
            room4Button.ForeColor = Color.Black;
            room5Button.ForeColor = Color.Black;
            room6Button.ForeColor = Color.Black;
            room7Button.ForeColor = Color.Black;
            room8Button.ForeColor = Color.Black;
            room9Button.ForeColor = Color.Black;
            room10Button.ForeColor = Color.Black;
            room11Button.ForeColor = Color.Black;
            room12Button.ForeColor = Color.Black;
            room13Button.ForeColor = Color.Black;
            room14Button.ForeColor = Color.Black;
            room15Button.ForeColor = Color.Black;
            
        }

        private void selectColour(Button button)
        {
            //Changes the colour for the selected room

            button.BackColor = Color.Olive;
            button.ForeColor = Color.White;
        }

        private void mapToggelButton_Click(object sender, EventArgs e)
        {
            if (mapToggle == false)
            {
                mapToggle = true;
                audioButton.Visible = false;
            }
            else
            {
                mapToggle = false;
                audioButton.Visible = true;
            }
        }

        private void intervalTimer_Tick(object sender, EventArgs e)
        {
            

            if (audioUses <= 0) //Disables audio lures if you run out
            {
                audioButton.Enabled = false ;
                aggressive = 1;
            }

            

            if (panelToggle == false) //Toggles between the two panels
            {
                panelNameLabel.Text = "Camera_System.EXE";

                mapPicture.Visible = true;

                mapToggleButton.Visible = true;

                if (mapToggle == false)
                {
                    //Only makes the rooms visible
                    enableRoomCams();

                    disableVentCams();

                    audioButton.Visible = true;

                }
                else if (mapToggle == true)
                {
                    //Only makes the vents visible
                    disableRoomCams();

                    enableVentCams();

                    audioButton.Visible = false;
                }

                if (currentPlayerRoom == 1 && currentRoom != 1) //Changes the images for each room
                {
                    this.BackgroundImage = Properties.Resources.CAM_01;
                }
                else if ( currentPlayerRoom == 1 && currentRoom == 1)
                {
                    this.BackgroundImage = Properties.Resources.CAM_01_ACTIVE;
                }

                else if (currentPlayerRoom == 2 && currentRoom != 2) // CAM 02
                {
                    this.BackgroundImage = Properties.Resources.CAM_02;
                }
                else if (currentPlayerRoom == 2 && currentRoom == 2)
                {
                    this.BackgroundImage = Properties.Resources.CAM_02_ACTIVE;
                }

                else if (currentPlayerRoom == 3 && currentRoom != 3) //CAM 3
                {
                    this.BackgroundImage = Properties.Resources.CAM_03;
                }
                else if (currentPlayerRoom == 3 && currentRoom == 3)
                {
                    this.BackgroundImage  = Properties.Resources.CAM_03_ACTIVE;
                }

                else if (currentPlayerRoom == 4 && currentRoom != 4) //CAM 04
                {
                    this.BackgroundImage = Properties.Resources.CAM_04;
                }
                else if (currentPlayerRoom == 4 && currentRoom == 4)
                {
                    this.BackgroundImage = Properties.Resources.CAM_04_ACTIVE;
                }

                else if (currentPlayerRoom == 5 && currentRoom != 5) //CAM 05
                {
                    this.BackgroundImage = Properties.Resources.CAM_05;
                }
                else if (currentPlayerRoom == 5 && currentRoom == 5)
                {
                    this.BackgroundImage= Properties.Resources.CAM_05_ACTIVE;
                }

                else if (currentPlayerRoom == 6 && currentRoom != 6) //CAM 06
                {
                    this.BackgroundImage = Properties.Resources.CAM_06;
                }
                else if (currentPlayerRoom == 6 && currentRoom == 6)
                {
                    this.BackgroundImage = Properties.Resources.CAM_06_ACTIVE;
                }

                else if (currentPlayerRoom == 7 && currentRoom != 7) //CAM 07
                {
                    this.BackgroundImage = Properties.Resources.CAM_07;
                }
                else if (currentPlayerRoom == 7 && currentRoom == 7)
                {
                    this.BackgroundImage = Properties.Resources.CAM_07_ACTIVE;
                }

                else if (currentPlayerRoom == 8 && currentRoom != 8) //CAM 08
                {
                    this.BackgroundImage = Properties.Resources.CAM_08;
                }
                else if (currentPlayerRoom == 8 && currentRoom == 8)
                {
                    this.BackgroundImage = Properties.Resources.CAM_08_ACTIVE;
                }

                else if (currentPlayerRoom == 9 && currentRoom != 9) //CAM 09
                {
                    this.BackgroundImage = Properties.Resources.CAM_09;
                }
                else if (currentPlayerRoom == 9 && currentRoom == 9)
                {
                    this.BackgroundImage = Properties.Resources.CAM_09_ACTIVE;
                }

                else if (currentPlayerRoom == 10 && currentRoom != 10) //CAM 10
                {
                    this.BackgroundImage = Properties.Resources.CAM_10;
                }
                else if (currentPlayerRoom == 10 && currentRoom == 10)
                {
                    this.BackgroundImage= Properties.Resources.CAM_10_ACTIVE;
                }

                else if (currentPlayerRoom == 11 && currentRoom != 11) //CAM 11
                {
                    this.BackgroundImage = Properties.Resources.CAM_11;
                }
                else if (currentPlayerRoom == 11 && currentRoom == 11)
                {
                    this.BackgroundImage = Properties.Resources.CAM_11_ACTIVE;
                }

                else if (currentPlayerRoom == 12 && currentRoom != 12) //CAM 12
                {
                    this.BackgroundImage = Properties.Resources.CAM_12;
                }
                else if (currentPlayerRoom == 12 && currentRoom == 12)
                {
                    this.BackgroundImage = Properties.Resources.CAM_12_ACTIVE;
                }

                else if (currentPlayerRoom == 13 && currentRoom != 13) //CAM 13
                {
                    this.BackgroundImage = Properties.Resources.CAM_13;
                }
                else if (currentPlayerRoom == 13 && currentRoom == 13)
                {
                    this.BackgroundImage = Properties.Resources.CAM_13_ACTIVE;
                }

                else if (currentPlayerRoom == 14 && currentRoom != 14) //CAM 14
                {
                    this.BackgroundImage = Properties.Resources.CAM_14;
                }
                else if (currentPlayerRoom == 14 && currentRoom == 14)
                {
                    this.BackgroundImage = Properties.Resources.CAM_14_ACTIVE;
                }

                else if (currentPlayerRoom == 15 && currentRoom != 15)
                {
                    this.BackgroundImage = Properties.Resources.CAM_15;
                }
                else if (currentPlayerRoom == 15 && currentRoom == 15)
                {
                    this.BackgroundImage = Properties.Resources.CAM_15_ACTIVE;
                }

                    //Makes stuff visible
                    timeLabel.Visible = true;
                panelToggleButton.Text = "<";
                blackberryToggleButton.Visible = false;
                luresLabel.Visible = false;
                airflowLabel.Visible = false;
            }
            else if (panelToggle == true)
            {
                panelNameLabel.Text = "";
                panelToggleButton.Text = ">";

                timeLabel.Visible = false;


                mapPicture.Visible = false;

                disableRoomCams();
                disableVentCams();

                blackberryToggleButton.Visible = true;
                
                luresLabel.Text = "AUDIO : " + audioUses.ToString();

                if (ventHealth >= 0)
                {
                    airflowLabel.Text = "AIRFLOW : " + ventHealth.ToString();
                }
                else if (ventHealth < 0)
                {
                    airflowLabel.Text = "AIRFLOW : 0";
                }

                    mapToggleButton.Visible = false;
                audioButton.Visible = false;
                if (currentRoom == 100 || currentRoom == 200 || currentRoom == 300)
                {
                    this.BackgroundImage = Properties.Resources.maintenanceRoom_ACTIVE;
                }
                else if (currentRoom == 400)
                {
                    this.BackgroundImage = Properties.Resources.maintenanceRoom_ACTIVE_400;
                }
                else
                {
                    this.BackgroundImage = Properties.Resources.maintenanceRoom;
                }
            }

            if (blackberryToggle  == true)
            {
                //Makes the blackberry visible
                blackberryPictureBox.Visible = true;
                ventButton.Visible = true;
                audioResetButton.Visible = true;

                luresLabel.Visible = true ;
                airflowLabel .Visible = true;

                panelToggleButton.Visible = false;

                blackberryToggleButton.Text = ">";
            }
            else if (blackberryToggle == false)
            {
                //Makes it not visible
                blackberryPictureBox.Visible = false;
                ventButton.Visible = false;
                audioResetButton.Visible= false;

                luresLabel.Visible= false;
                airflowLabel.Visible= false;

                panelToggleButton.Visible = true;

                blackberryToggleButton.Text = "<";
            }

        }

        private void disableRoomCams()
        {
            room1Button.Visible = false;
            room2Button.Visible = false;
            room3Button.Visible = false;
            room4Button.Visible = false;
            room5Button.Visible = false;
            room6Button.Visible = false;
            room7Button.Visible = false;
            room8Button.Visible = false;
            room9Button.Visible = false;
            room10Button.Visible = false;
        }

        private void enableRoomCams()
        {
            room1Button.Visible = true;
            room2Button.Visible = true;
            room3Button.Visible = true;
            room4Button.Visible = true;
            room5Button.Visible = true;
            room6Button.Visible = true;
            room7Button.Visible = true;
            room8Button.Visible = true;
            room9Button.Visible = true;
            room10Button.Visible = true;
        }

        private void disableVentCams()
        {
            room11Button.Visible = false;
            room12Button.Visible = false;
            room13Button.Visible = false;
            room14Button.Visible = false;
            room15Button.Visible = false;
        }

        private void enableVentCams()
        {
            room11Button.Visible = true;
            room12Button.Visible = true;
            room13Button.Visible = true;
            room14Button.Visible = true;
            room15Button.Visible = true;
        }

        private void audioButton_Click(object sender, EventArgs e)
        {
            //Audio lure for the monster, will lure it away

            Random randNum = new Random();
            int selectedNum = randNum.Next(0, 8);

            if (selectedNum < 6) //If the audio lure works, 86% chance of it working
            {
                if (currentPlayerRoom == 1 && currentRoom == 400)
                {
                    currentRoom = 1;
                }
                else if (currentPlayerRoom == 2 && (currentRoom == 100 || currentRoom == 200 || currentRoom == 300))
                {
                    currentRoom = 2;
                }
                else if (currentPlayerRoom == 2 && currentRoom == 3)
                {
                    currentRoom = 2;
                }
                else if (currentPlayerRoom == 2 && currentRoom == 4)
                {
                    currentRoom = 2;
                }
                else if (currentPlayerRoom == 2 && currentRoom == 5)
                {
                    currentRoom = 2;
                }
                else if (currentPlayerRoom == 3 && currentRoom == 2)
                {
                    currentRoom = 3;
                }
                else if (currentPlayerRoom == 3 && currentRoom == 4)
                {
                    currentRoom = 3;
                }
                else if (currentPlayerRoom == 4 && currentRoom == 2)
                {
                    currentRoom = 4;
                }
                else if (currentPlayerRoom == 4 && currentRoom == 3)
                {
                    currentRoom = 4;
                }
                else if (currentPlayerRoom == 5 && currentRoom == 2)
                {
                    currentRoom = 5;
                }
                else if (currentPlayerRoom == 5 && (currentRoom == 6 || currentRoom == 7 || currentRoom == 8))
                {
                    currentRoom = 5;
                }
                else if (currentPlayerRoom == 6 && (currentRoom == 5 || currentRoom == 7))
                {
                    currentRoom = 6;
                }
                else if (currentPlayerRoom == 7 && (currentRoom == 6 || currentRoom == 8))
                {
                    currentRoom = 7;
                }
                else if (currentPlayerRoom == 8 && (currentRoom == 7 || currentRoom == 5 || currentRoom == 9))
                {
                    currentRoom = 8;
                }
                else if (currentPlayerRoom == 9 && (currentRoom == 8 || currentRoom == 10))
                {
                    currentRoom = 9;
                }
                else if (currentPlayerRoom == 10 && currentRoom == 9)
                {
                    currentRoom = 10;
                }

            }
            

            audioUses--;

            testOutputLabel.Text += "\nForced move to room " + currentRoom.ToString() + " - Audio Uses Left : " + audioUses.ToString() + "\n";
        }

        private async void audioResetButton_Click(object sender, EventArgs e)
        {
            audioResetButton.Text = "RESETTING";
            disableItems();

            Random rand = new Random();
            int resetTime = rand.Next(5000, 8000); //Random number for reset time

            await Task.Delay(resetTime); //Takes between 5 and 8 seconds to reset

            audioResetButton.Text = "RESET AUDIO";
            enableItems();

            int audioNum = rand.Next(4, 6);
            audioUses = audioNum; //Random number of audio uses between 2 and 6
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelToggleButton_Click(object sender, EventArgs e)
        {
            //Changes the boolean when you click the button
            if (panelToggle == false)
            {
                panelToggle = true;
            }
            else { panelToggle = false; }


            
        }

        private void blackberryToggleButton_Click(object sender, EventArgs e)
        {
            //Changes the boolean when you click the button
            if (blackberryToggle == false)
            {
                blackberryToggle = true;
            }
            else { blackberryToggle = false; }
        }
    }
}
