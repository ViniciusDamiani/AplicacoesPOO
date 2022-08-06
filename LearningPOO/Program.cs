using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciando objeto aluno para receber os metodos de calcular média
            Aluno aluno = new Aluno();

            //Atribuindo valor a instancia da classe
            Console.WriteLine("Informe seu nome: ");
            Aluno.Name = Console.ReadLine();

            Console.WriteLine("Informe sua primeira nota: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe sua segunda nota: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe sua terceira nota: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            //Efetuado o metodo de calcular média
            aluno.CalculateAverage(n1,n2,n3);
            //Imprimindo a média do Aluno
            Console.WriteLine("A sua média Sr."+ Aluno.Name + " foi: " + Aluno.NotesAverage);





            Console.ReadKey();
        }
    }
}
