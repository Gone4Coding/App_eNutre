using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministrationApp_eNutre.Classes;

namespace AdinistrationApp_eNutre.Classes
{
    class TxtHandler
    {
        private List<string> vegetal;
        private string[] vegetalSplit;
        private string[] vegetalSplitP;
        private string[] vegetalSplitComma;

        public void carregarTXT()
        {
            string ficheiroTXT =
                System.IO.File.ReadAllText(
                    @"C:\Users\j17vi\Source\Repos\App_eNutre\AdinistrationApp_eNutre\Info\calorias_vegetais.txt");

            string[] vegetables = ficheiroTXT.Split('\n');
            // Vegetable vegetable = new Vegetable(vegetables); 

            for (int i = 0; i < vegetables.Length; i++)
            {
                vegetalSplit = vegetables[i].Split(' ');
                vegetalSplitP = vegetables[i].Split('(');
            }  
        }

        public string devolveNome()
        {
            return vegetalSplit[4];
        }

        public string devolveCalorias()
        {
            return vegetalSplit[1];
        }
        
        public string devolveQuantidade()
        {
           // int a = vegetalSplitP.Count();
            if (vegetalSplitP.Count() == 2)
            {
                return vegetalSplitP[1];
            }
            else if (vegetalSplitP.Count() == 3)
            {
                return vegetalSplitP[2];
            }
            else
            {
                return vegetalSplitP[3];
            }
            
        }

        public string devolveExtaInfo()
        {
            if (vegetalSplitP.Count() == 2)
            {
                return "";
            }
            else
            {
                return vegetalSplitP[1];
            }
            
        }
        /*
        public string[] devolveVegetalLista()
        {
            return vegetalSplit;
        }

        public string[] devolveVegetalListaP()
        {
            return vegetalSplitP;
        }*/

       
    }
}
