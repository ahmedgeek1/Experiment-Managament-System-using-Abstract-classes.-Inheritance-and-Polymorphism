using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment11
{
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {//close this form
            this.Close();
        }

        public void reviewExperienceDetails(string experimentNumber, string studentName, string experimentDescription, string color, string weight, string volume, string gravity, string velocity)
        {   //setting the text passed as parameters to the labels of the form
            lblStudentName.Text = "Student Name: "+studentName;
            lblExperimentNumber.Text = "Experiment Number: " + experimentNumber.ToString();
            lblExperimentDescription.Text = "Experiment Description: "+experimentDescription;
            lblResultColor.Text = "Result Color: "+color;
            lblResultVolume.Text = "Result Volume: "+volume;
            lblResultWeight.Text = "Result Weight: "+weight;
            lblGravity.Text = "Gravity: " + gravity;
            lblVelocity.Text = "Velocity: " + velocity;
        }

        private void lblExperimentDetailsPopup_Click(object sender, EventArgs e)
        {

        }

        private void Review_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenTheDoor_Click(object sender, EventArgs e)
        {
            Space_Experiment exp1 = new Space_Experiment(); //instanciate a new experiment
            exp1.OpenThePodBayDoors(this); //call a method in that experiment
            exp1 = null; //set to null the space experiment created
        }
    }
}
