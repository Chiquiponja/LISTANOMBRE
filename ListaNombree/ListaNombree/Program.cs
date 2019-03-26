using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNombree
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[,] P2 = new string[3, 2] { { "abcdefghijklmnoAEFTM", "pqrstuvwxyzABCDEflUM" }, { "FGHIJKLMNOPQRSTmdevb", "VWXYZgmosfeyaliAMOPT" }, { "grereETYUFNMAWPcbgsm", "grereETYUFNMAWPcbgsm" } };
            string P2 =  "abcdefghijklmnoAEFTMpqrstuvwxyzABCDEflUMGHIJKLMNOPQRSTmdevVWXYZgmosfeyaliAMOPTrereETYUFNMAWPcbggrereETYUFNMAWPcbgsm" ;
            Random obj = new Random();
            int longitud = P2.Length;

            char letra;
            
            int longitudnuevacadena = 100;
            string nuevacadena = " ";
           
            Console.WriteLine("Examen", nuevacadena);
            Console.WriteLine(" ");
            //string[,] letra;
            //letra = new string[3, 2];
            //for (int fila = 0; fila < 3; fila++)
            //{
            //    int s = obj.Next(3, 2);
            //    for (int col = 0; col < longitudnuevacadena; col++)
            //    {

            //        letra[fila, col]=P2;


            //        nuevacadena += letra.ToString();
            //    }

            //    Console.WriteLine();
                for (int i = 0; i < longitudnuevacadena; i++)
                {
                    letra =P2 [obj.Next(longitud)];
                    nuevacadena += letra.ToString();
                }
            Console.WriteLine(nuevacadena);
        }
            //if (P2[0,1].ToUpper().StartsWith("A") ||
            //       P2[1, 1].ToUpper().StartsWith("E") ||
            //       P2[2, 1].ToUpper().StartsWith("I") ||
            //       P2[3, 1].ToUpper().StartsWith("O") ||
            //       P2[4, 1].ToUpper().StartsWith("U"))
            //{
            //    Console.WriteLine(P2);
            //}
            //P2 = letra.OrderBy(x => x.lista).ToList();
            //foreach (var Nombre in listaOrdenada)
            //{
            //    Console.WriteLine(Nombre.lista);
            }


            
        }
   



    

