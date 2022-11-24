using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    }
    
        class Car { 
           // public string name { get; set; }
          //  public double speed { get; set; }
          //  public Car(string cName, double cSpeed) {
            //    name = cName;
              //  speed = cSpeed;
            //}
            //public void showCar() {
            //  if (boxVal.selectedItem == name) { }

            //}

            public string name { get; set; }
            public int speed { get; set; }

            public int curSpeed { get; set; }

            public void SetBrand(string Brand) {
                name = Brand;
            }

            public void SetMaxSpeed(int maxspeed) {
                speed = maxspeed;
            }
            public void SpeedUp()
            {
                if (curSpeed > speed)
                {
                    curSpeed = speed;
                }
                if (curSpeed < 0)
                {
                    curSpeed = 0;
                }
                else
                {
                    curSpeed += 7;
                }
            }

            public void SlowDown() {

                if (curSpeed < 0)
                {
                    curSpeed = 0;
                }
                else
                {
                    curSpeed -= 10;
                }
            }
            public string GetInfo() {
                return "The " + name + " is going " + curSpeed + " km/h Max speed is " + speed;
            }

        }

        Car car1 = new Car();

        private void button1_Click(object sender, EventArgs e)
        {
            car1.SetBrand(textBox1.Text);
            car1.SetMaxSpeed(Int32.Parse(textBox2.Text));
            label3.Text = car1.GetInfo();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            car1.SpeedUp();
            label3.Text = car1.GetInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            car1.SlowDown();
            label3.Text = car1.GetInfo();
        }
    }
}
