using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationApp_eNutre.Classes
{
    public class Activity
    {
        private string nome;
        private string metName;
        private int caloriasValue;
        private string caloriasUnit;
        private string met;

        public Activity(string nome, int caloriasValue, string caloriasUnit, string metName, string met)
        {
            this.nome = nome;
            this.met = met;
            this.caloriasUnit = caloriasUnit;
            this.caloriasValue = caloriasValue;
            this.metName = metName;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string MetName
        {
            get { return metName; }
            set { metName = value; }
        }

        public int CaloriasValue
        {
            get { return caloriasValue; }
            set { caloriasValue = value; }
        }

        public string CaloriasUnit
        {
            get { return caloriasUnit; }
            set { caloriasUnit = value; }
        }

        public string Met
        {
            get { return met; }
            set { met = value; }
        }
    }
}
