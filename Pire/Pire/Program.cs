using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pire
{
    class Program
    {

        protected static int origRow;
        protected static int origCol;
        

        static void Main(string[] args)
        {

            string texto = "";
            int cont;
            string valor;

            Console.Write("Qual o tamanho da pirâmide ? ");
            Console.Write("\n: ");
            valor = Console.ReadLine();

            cont = Convert.ToInt32(valor);

            for (int i = 0; i < Convert.ToInt32(valor); i++)
            {


                texto = texto + "**";
                Posicao(texto, cont, i + 3);
                cont = cont - 1;

            }
            Console.Write("\n\n Aperte qualquer tecla para sair ! ");
            Console.ReadLine();
        }


        protected static void Posicao(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
    }
}
