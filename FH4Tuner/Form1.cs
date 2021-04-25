using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FH4Tuner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void frontDampingLabel_Click(object sender, EventArgs e)
        {

        }

        private void frontARBBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            //collect and cast inputs for calcs
            double frontWeight = Convert.ToDouble(frontWeightInput.Text);
            double rearWeight = 1 - frontWeight;
            double minSpring = Convert.ToDouble(minSpringInput.Text);
            double maxSpring = Convert.ToDouble(maxSpringInput.Text);
            double dampRatio = Convert.ToDouble(dampRatioSelection.SelectedItem);
            string drivetrain = Convert.ToString(drivetrainInput.SelectedItem);
            double frontAcc, frontDec, rearAcc, rearDec;
            string raceType = Convert.ToString(raceTypeInput.SelectedItem);


            //calc base results
            double frontARB = 64 * frontWeight + 1;
            double rearARB = 64 * rearWeight + 1;
            double frontSpring = (maxSpring - minSpring) * frontWeight + minSpring;
            double rearSpring = (maxSpring - minSpring) * rearWeight + minSpring;
            double frontDamp = (17 * frontWeight + 3);
            double rearDamp = (17 * rearWeight + 3);
            double frontBump = frontDamp * dampRatio;
            double rearBump = rearDamp * dampRatio;

            //set base differential tune
            switch (drivetrain)
            {
                case "AWD":
                    frontAcc = 30;
                    frontDec = 15;
                    rearAcc = 65;
                    rearDec = 50;
                    break;

                case "RWD":
                    frontAcc = 0;
                    frontDec = 0;
                    rearAcc = 70;
                    rearDec = 60;
                    break;

                case "FWD":
                    frontAcc = 40;
                    frontDec = 20;
                    rearAcc = 0;
                    rearDec = 0;
                    break;

                default:
                    frontAcc = 0;
                    frontDec = 0;
                    rearAcc = 0;
                    rearDec = 0;
                    break;
            }

            //adjust for race type selection
            switch (raceType)
            {
                case "Circuit/Street":
                    //no changes needed
                    break;

                case "Rally/Cross Country":
                    //decrease ARBs, Bump, Rebound and increase Dif Lock
                    frontARB    *= 0.2;
                    rearARB     *= 0.2;
                    frontDamp   *= 0.8;
                    rearDamp    *= 0.8;
                    frontBump   *= 0.9;
                    rearBump    *= 0.9;
                    frontAcc    *= 1.15;
                    frontDec    *= 1.15;
                    rearAcc     *= 1.15;
                    rearDec     *= 1.15;
                    break;

                case "Drifting":
                    //full lock on rear, increase front ARB and springs
                    frontARB *= 1.20;
                    frontSpring *= 1.15;
                    frontAcc = 0;
                    frontDec = 0;
                    rearAcc = 100;
                    rearDec = 20;
                    break;
            }

            //display results
            frontARBBox.Text = Convert.ToString(frontARB);
            rearARBBox.Text = Convert.ToString(rearARB);

            frontSpringBox.Text = Convert.ToString(frontSpring);
            rearSpringBox.Text = Convert.ToString(rearSpring);

            frontDampBox.Text = Convert.ToString(frontDamp);
            rearDampBox.Text = Convert.ToString(rearDamp);

            frontBumpBox.Text = Convert.ToString(frontBump);
            rearBumpBox.Text = Convert.ToString(rearBump);

            fAccBox.Text = Convert.ToString(frontAcc);
            fDecBox.Text = Convert.ToString(frontDec);
            rAccBox.Text = Convert.ToString(rearAcc);
            rDecBox.Text = Convert.ToString(rearDec);

        }
    }
}
