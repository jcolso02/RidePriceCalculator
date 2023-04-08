// S5034
// CIS 199-50
// program 2
// October 21, 2021

// This Program is the calculator for IRyde's prices of Company A, B, and C based on number of passengers, distance, and type of vehicle.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Variables

            int passengers;
            double distance;
            double[] coACarTypeCost = new double[] { 50, 40, 25, 15, 7 };
            double[] coBCarTypeCost = new double[] { 40, 40, 25, 15, 15 };
            double[] coCCarTypeCost = new double[] { 20, 20, 20, 20, 20 };
            bool validPassengers = false;
            bool validDistance = false;
            bool validCarType = false;

            // Validating User Input

            // Passenger
            if(int.TryParse(passengersTextBox.Text, out passengers))
            {
                if(passengers > 0 && passengers <= 12)
                {
                    validPassengers = true;
                    this.passengersErrorLabel.Visible = false;
                }
                else
                {
                    this.passengersErrorLabel.Visible = true;
                }
            }
            else
            {
                this.passengersErrorLabel.Visible = true;
            }

            // Distance
            if (double.TryParse(distanceTextBox.Text, out distance))
            {
                if (distance > 0)
                {
                    validDistance = true;
                    this.distanceErrorLabel.Visible = false;
                }
                else
                {
                    this.distanceErrorLabel.Visible = true;
                }
            }
            else
            {
                this.distanceErrorLabel.Visible = true;
            }

            // Car Type
            if (carComboBox.SelectedIndex == -1)
            {
                this.carTypeErrorLabel.Visible = true;
            }
            else
            {
                validCarType = true;
                this.carTypeErrorLabel.Visible = false;
            }


            if (validPassengers && validDistance && validCarType)
            {

                //
                // Company A
                //

                // Passengers
                double passengersAPrice;
                const int passengersARate = 2;

                passengersAPrice = passengers * passengersARate;

                // Distance
                double distanceAPrice;
                const double distanceARate = .02;

                distanceAPrice = distance * distanceARate;

                // Car Type
                double ctACost = coACarTypeCost[carComboBox.SelectedIndex];

                // Calculation
                double coATotal = passengersAPrice + distanceAPrice + ctACost;

                // Display
                coATextBox.Text = coATotal.ToString("C2");



                //
                // Company B
                //

                // Passengers
                double passengerBPrice = 0;

                if (passengers <= 2)
                {
                    passengerBPrice = 20 * passengers;
                }
                else if (passengers > 2 && passengers < 7)
                {
                    passengerBPrice = 15 * passengers;
                }
                else if (passengers >= 7 && passengers <= 12)
                {
                    passengerBPrice = 5 * passengers;
                }

                // Distance
                double distanceBPrice;
                const double distanceBRate = .1;

                distanceBPrice = distance * distanceBRate;

                // Car Type
                double ctBCost = coBCarTypeCost[carComboBox.SelectedIndex];

                // Calculation
                double coBTotal = passengerBPrice + distanceBPrice + ctBCost;

                // Display
                coBTextBox.Text = coBTotal.ToString("C2");


                //
                // Company C
                //

                // Passengers
                double passengersCPrice;
                const double passengersCRate = .25;

                passengersCPrice = passengers * passengersCRate;

                // Distance
                double distanceCPrice;

                if(distance >= 200)
                {
                    distanceCPrice = 40;
                }
                else if(distance >= 100 && distance <= 199)
                {
                    distanceCPrice = 35;
                }
                else if(distance >= 50 && distance <= 99)
                {
                    distanceCPrice = 25;
                }
                else if(distance >= 10 && distance <= 49)
                {
                    distanceCPrice = 15;
                }
                else
                {
                    distanceCPrice = 5;
                }

                // Car Type
                double ctCCost = coCCarTypeCost[carComboBox.SelectedIndex];

                // Calculation
                double coCTotal = passengersCPrice + distanceCPrice + ctCCost;

                // Display
                coCTextBox.Text = coCTotal.ToString("C2");

                // Results
                if(coATotal <= coBTotal && coATotal <= coCTotal)
                {
                    resultsTextBox.Text = "The lowest cost company is: A";
                }
                else if(coBTotal <= coATotal && coBTotal <= coCTotal)
                {
                    resultsTextBox.Text = "The lowest cost company is: B";
                }
                else
                {
                    resultsTextBox.Text = "The lowest cost company is: C";
                }
            }
            else // Deleting previous outputs if there are any invalid inputs
            {
                coATextBox.Text = "";
                coBTextBox.Text = "";
                coCTextBox.Text = "";
                resultsTextBox.Text = "";

            }

        }

    }
}
