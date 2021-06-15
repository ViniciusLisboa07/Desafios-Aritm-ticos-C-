using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Desafios_Aritméticos
//{

   /* 
    * Leia 3 valores de ponto flutuante 
    * A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados.
    * A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos,
    * sempre escrevendo uma mensagem adequada:

        se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
        se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
        se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
        se A2<B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
        se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
        se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES
*/

    //class Desafio2
    //{
        //static void Main(string[] args) 
        //{
        //    string[] s = Console.ReadLine().Split(' ');

        //    double[] aux = new double[3];
        //    aux[0] = double.Parse(s[0]);
        //    aux[1] = double.Parse(s[1]);
        //    aux[2] = double.Parse(s[2]);

        //    Array.Sort(aux);
        //    Array.Reverse(aux);

        //    double a = aux[0];
        //    double b = aux[1];
        //    double c = aux[2];

        //    double a2 = Math.Pow(a, 2);
        //    double b2 = Math.Pow(b, 2);
        //    double c2 = Math.Pow(c, 2);

        //    //continue a solucao
        //    if ( a >= b + c )
        //        Console.WriteLine("NAO FORMA TRIANGULO");
        //    else if ( a2 == b2 + c2 )
        //        Console.WriteLine("TRIANGULO RETANGULO");
        //    else if ( a2 > b2 + c2 )
        //       Console.WriteLine("TRIANGULO OBTUSANGULO");
        //    else if ( a2 < b2 + c2 )
        //        Console.WriteLine("TRIANGULO ACUTANGULO");
        //    if (a2 == b2 && b2 == c2)     
        //        Console.WriteLine("TRIANGULO EQUILATERO");
        //    if (a2 == b2 ^ b2 == c2)
        //        Console.WriteLine("TRIANGULO ISOSCELES");

//        }
//    }
//}
