using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Media;

namespace Farmerv1
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer(@"C:\Users\Alex\Documents\Visual Studio 2017\Projects\Farmerv1\Farmerv1\Resources\Push.wav");
        string[] LeftArray = new string[4];
        string[] BoatArray = new string[2];
        string[] RightArray = new string[4];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeftArray[0] = "Farmer";
            LeftArray[1] = "Goat";
            LeftArray[2] = "Wolf";
            LeftArray[3] = "Cabbage";
        }

        public void ResetGame()
        {
            BoatBox.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);
            BoatBox.Invalidate();
            ClearArray(BoatArray);
            BoatBox.Location = new Point(248, 157);
            MessageBox.Show("Boat is empty now!");
            Farmer.Location = new Point(33, 31);
            Goat.Location = new Point(33, 87);
            Wolf.Location = new Point(33, 144);
            Cabbage.Location = new Point(33, 200);
            ClearArray(LeftArray);
            LeftArray[0] = "Farmer";
            LeftArray[1] = "Goat";
            LeftArray[2] = "Wolf";
            LeftArray[3] = "Cabbage";
            ClearArray(RightArray);
        }

        public void ResetGame(bool value)
        {
            if (value)
            {
                BoatBox.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);
                BoatBox.Invalidate();
                ClearArray(BoatArray);
                BoatBox.Location = new Point(248, 157);
                MessageBox.Show("Boat is empty now!");
                Farmer.Location = new Point(33, 31);
                Goat.Location = new Point(33, 87);
                Wolf.Location = new Point(33, 144);
                Cabbage.Location = new Point(33, 200);
                ClearArray(LeftArray);
                LeftArray[0] = "Farmer";
                LeftArray[1] = "Goat";
                LeftArray[2] = "Wolf";
                LeftArray[3] = "Cabbage";
                ClearArray(RightArray);
            }
        }

        public void MembersBinding()
        {
            if (!RightArray.Contains("Farmer"))
            {
                if (RightArray.Contains("Goat") && RightArray.Contains("Cabbage"))
                {
                    MessageBox.Show("Cabbage was eatet \n You Lost!");
                    ResetGame();
                }
                if (RightArray.Contains("Goat") && RightArray.Contains("Wolf"))
                {
                    MessageBox.Show("Goat was eatet \n You Lost!");
                    ResetGame();
                }
            }
            if (!LeftArray.Contains("Farmer"))
            {
                if (LeftArray.Contains("Goat") && LeftArray.Contains("Cabbage"))
                {
                    MessageBox.Show("Cabbage was eatet \n You Lost!");
                    ResetGame();
                }
                if (LeftArray.Contains("Goat") && LeftArray.Contains("Wolf"))
                {
                    MessageBox.Show("Goat was eatet \n You Lost!");
                    ResetGame();
                }
            }
        }

        public void ClearArray(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = string.Empty;
            }
            label1.Text = string.Empty;
        }

        public void ClearArray(string[] s, string temp)
        {
            if (s.Contains(temp))
            {
                var value = Array.IndexOf(s, temp);
                s[value] = string.Empty;
            }
        }

        public void MovePic(PictureBox name, Point endPoint)
        {
            if (endPoint != null)
            {
                name.Location = endPoint;
            }
            else
            {
                MessageBox.Show("Move Exception");
            }
        }

        public void BoatFinishRight(string s)
        {   
                switch (s)
                {
                    case "Farmer":
                        MovePic(Farmer, new Point(789, 42));
                    RightArray[0] = s;
                    ClearArray(LeftArray, "Farmer");
                    break;
                    case "Goat":
                        MovePic(Goat, new Point(789, 98));
                    RightArray[1] = s;
                    ClearArray(LeftArray, "Goat");
                    break;
                    case "Wolf":
                        MovePic(Wolf, new Point(789, 154));
                    RightArray[2] = s;
                    ClearArray(LeftArray, "Wolf");
                    break;
                    case "Cabbage":
                        MovePic(Cabbage, new Point(789, 210));
                    RightArray[3] = s;
                    ClearArray(LeftArray, "Cabbage");
                    break;
                }
            if (RightArray.Contains("Goat") && RightArray.Contains("Wolf") && RightArray.Contains("Cabbage") && RightArray.Contains("Farmer"))
            {
                MessageBox.Show("You Win!");
                Thread.Sleep(1500);
                ResetGame(true);
                //Thread.Sleep(1500);
                //Application.Exit();
            }
        }

        public void BoatFinishLeft(string s)
        {
            switch (s)
            {
                case "Farmer":
                    MovePic(Farmer, new Point(33, 31));
                    LeftArray[0] = s;
                    ClearArray(RightArray, "Farmer");
                    break;
                case "Goat":
                    MovePic(Goat, new Point(33, 87));
                    LeftArray[1] = s;
                    ClearArray(RightArray, "Goat");
                    break;
                case "Wolf":
                    MovePic(Wolf, new Point(33, 144));
                    LeftArray[2] = s;
                    ClearArray(RightArray, "Wolf");
                    break;
                case "Cabbage":
                    MovePic(Cabbage, new Point(33, 200));
                    LeftArray[3] = s;
                    ClearArray(RightArray, "Cabbage");
                    break;
            }
        }

        public void BoatAdd(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                if (BoatArray[0] != name && BoatArray[1] != name)
                {
                    if (string.IsNullOrEmpty(BoatArray[0]))
                    {
                        BoatArray[0] = name;
                        label1.Text += "\n" + BoatArray[0];
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(BoatArray[1]))
                        {
                            BoatArray[1] = name;
                            label1.Text += "\n" + BoatArray[1];
                        }
                        else MessageBox.Show("Boat is already full!");
                    }
                }
            }
        }

        public bool BoatMove()
        {
            try
            {
                player.Load();
                player.Play();
                MembersBinding();
                if (BoatBox.Location.X < 400)
                {
                    var xB = BoatBox.Location.X;
                    var yB = BoatBox.Location.Y;
                    for (int i = 0; i < 320; i += 10)
                    {
                        BoatBox.Location = new Point(xB + i, yB);
                        Thread.Sleep(320);
                    }
                    for (int i = 0; i < BoatArray.Length; i++)
                    {
                        BoatFinishRight(BoatArray[i]);
                    }
                }
                else
                {
                    var xB = BoatBox.Location.X;
                    var yB = BoatBox.Location.Y;
                    for (int i = 0; i < 320; i += 10)
                    {
                        BoatBox.Location = new Point(xB - i, yB);
                        Thread.Sleep(320);
                    }
                    for (int i = 0; i < BoatArray.Length; i++)
                    {
                        BoatFinishLeft(BoatArray[i]);
                    }
                }
                    BoatBox.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);
                    BoatBox.Invalidate();
                    ClearArray(BoatArray);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            BoatAdd(LeftArray[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BoatAdd(LeftArray[1]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BoatAdd(LeftArray[2]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BoatAdd(LeftArray[3]);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ResetGame();
        }//Reset

        private void button5_Click(object sender, EventArgs e)
        {
            if (BoatArray.Contains("Farmer"))
            {
                BoatMove();
            }
            else
            {
                MessageBox.Show("Farmer is not on the boat!");
            }
        }//Start

        private void btnFarmerBack_Click(object sender, EventArgs e)
        {
            BoatAdd(RightArray[0]);
        }

        private void btnGoatBack_Click(object sender, EventArgs e)
        {
            BoatAdd(RightArray[1]);
        }

        private void btnWolfBack_Click(object sender, EventArgs e)
        {
            BoatAdd(RightArray[2]);
        }

        private void btnCabbageBack_Click(object sender, EventArgs e)
        {
            BoatAdd(RightArray[3]);
        }

        private void btnClearBoat_Click(object sender, EventArgs e)
        {
            ClearArray(BoatArray);
        }//Clear
    }
}
