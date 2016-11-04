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
        private int calorias;
        private string met;

        public Activity(string nome, int calorias, string met)
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

        public int Calorias
        {
            get { return calorias; }
            set { calorias = value; }
        }

        public string Met
        {
            get { return met; }
            set { met = value; }
        }

        public override string ToString()
        {
            return "Activity: " + nome + "; MET: " + met + "; Cals/h: " + calorias;
        }
    }
}
