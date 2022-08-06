using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPOO
{
    //Classe
    class Aluno
    {
        //Atributos
        public static string Name = "";
        public static string LongName = "";
        public static int NrHeadquarters = 0;

        public static int NotesAverage = 0;

        //Metodo: Calcula Media
        public void CalculateAverage(int Note1, int Note2, int Note3)
        {
            NotesAverage = Note1 + Note2 + Note3 / 3;
        }

        //Método: Verifica Situação
        public void CheckedSituation() 
        { 
            if (NotesAverage < 7)
            {
                string MessageSituation = "Você reprovou! :(";
            }
            else
            {
                string MessageSituation = "Você passou! :)";
            }
        }



    }
}