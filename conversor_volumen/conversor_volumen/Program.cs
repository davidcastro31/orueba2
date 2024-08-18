using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversor_volumen
{
    class Program
    {
        static void Main(string[] args) {
            // Matriz de conversión
            double[,] conversiones = {
            // ml,     l,    cm3,    m3,     gal,   pint,    oz,    qt,     ft3,   in3
            { 1,     0.001,  1,  0.000001, 0.000264, 0.002113, 0.033814, 0.001057, 0.0000353, 0.061024 }, // ml
            { 1000,  1,    1000,   0.001,  0.264172, 2.11338, 33.814,  1.05669, 0.0353147, 61.0237  }, // l
            { 1,     0.001,  1,   000000.1, 0.000264, 0.002113, 0.033814, 0.001057, 0.0000353, 0.061024 }, // cm3
            { 1000000,   1000,   1000000,   1,  264.172, 2113.38, 33814, 1056.69, 35.3147, 61023.7  }, // m3
            { 3785.41, 3.78541,  3785.41, 0.003785, 1,    8,   128,   4,  0.133681, 231     }, // gal
            { 473.176, 0.473176, 473.176, 0.000473, 0.125, 1, 16,  0.5, 0.0167101, 28.875  }, // pint
            { 29.5735, 0.0295735, 29.5735, 0.0000295, 0.0078125, 0.0625, 1,   0.03125, 0.00104438, 1.80469 }, // oz
            { 946.353, 0.946353, 946.353, 0.000946, 0.25,   2,   32,  1,  0.0334201, 57.75   }, // qt
            { 28316.8, 28.3168,  28316.8, 0.0283168, 7.48052, 59.8442, 957.506, 29.9221, 1,    1728    }, // ft3
            { 16.3871, 0.0163871, 16.3871, 0.0000164, 0.004329, 0.034632, 0.554113, 0.017316, 0.000578704, 1 }//in3
            };


            // Nombres de las unidades
            String[] unidades = { "Mililitro", "litro", "Centrimetros cubico", "Metro cubico", "Galones EE.UU", "Pinta EE.UU", "Onza EE.UU", "Un cuarto de galon EE.UU", "Pie cubico ", "Pulgada cubica" };

            // Ejemplo de conversión
            Console.WriteLine("Conversión de unidades de volumen:");
            Console.Write("Ingresa el valor a convertir: ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("Selecciona la unidad que desea convertir:");
            for (int i = 0; i < unidades.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {unidades[i]}");
            }
            Console.WriteLine();
            int convertir = int.Parse(Console.ReadLine())-1;
            Console.WriteLine();

            Console.WriteLine("Selecciona la unidad a la que desea convertir:");
            for (int i = 0; i < unidades.Length; i++)
            {
                Console.WriteLine($"{i + 1} {unidades[i]}");
            }
            Console.WriteLine();
            int unidad_a_convertir = int.Parse(Console.ReadLine())-1;
            Console.WriteLine();

            double resultado = valor * conversiones[convertir, unidad_a_convertir];

            Console.WriteLine($"{valor} {unidades[convertir]} es igual a {resultado} {unidades[unidad_a_convertir]}");

            //pausa
            Console.ReadLine();

        }


        
    }
}

