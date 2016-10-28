using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationApp_eNutre.Classes
{
    class Activity
    {
        private string exercise;
        private double met;
        private int calorieComsuption;

        public Activity(string exercise, double met, int calorieComsuption)
        {
            this.exercise = exercise;
            this.met = met;
            this.calorieComsuption = calorieComsuption;
        }

        public string getExercise()
        {
            return exercise;
        }

        public double getMet()
        {
            return met;
        }

        public int getCaloriesComsuption()
        {
            return calorieComsuption;
        }
    }
}
