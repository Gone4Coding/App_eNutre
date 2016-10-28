using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationApp_eNutre.Classes
{
    class Activity
    {
        private string nome;
        private double met;
        private int calorias;

        public Activity(string nome, double met, int calorias)
        {
            this.nome = nome;
            this.met = met;
            this.calorias = calorias;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Met
        {
            get { return met; }
            set { met = value; }
        }

        public int Calorias
        {
            get { return calorias; }
            set { calorias = value; }
        }

        public override string ToString()
        {
            return "Activity: " + nome + "; MET: " + met + "; Cals/h: " + calorias;
        }
    }
}
