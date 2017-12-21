using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment11
{
    class Space_Experiment : Experiment
    {
        //declaring variables
        private double _gravity;
        private int _velocity;
        private double _volume;

        //gravity public property
        public double Gravity
        {
            get
            {
                return _gravity;
            }

            set
            {
                _gravity = value;
            }
        }

        //velocity public property
        public int Velocity
        {
            get
            {
                return _velocity;
            }

            set
            {
                _velocity = value;
            }
        }

        //override the get and set of ResultVolume of the base class
        public override double ResultVolume
        {
            get
            {
                return _volume;
            }

            set
            {
                double var = value * 1.25;
                _volume = var;
            }
        }

        //parameterless constructor
        public Space_Experiment(){}
        
        //contructor with student name as a parameter
        public Space_Experiment(string name)
        {
            StudentName = name;
        }

        //constructor with experiment number and experiment desrcription as parameter
        public Space_Experiment(int experimentNumber, string experimentDescription)
        {
            ExperimentNumber = experimentNumber;
            ExperimentDescription = experimentDescription;
        }

        public void OpenThePodBayDoors(Form form)
        {
            //method to show the message box
            MessageBox.Show(form, "I am sorry Dave, I can’t do that");
        }
    }
}
