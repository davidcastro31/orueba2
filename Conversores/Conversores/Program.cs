using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores
{
    class Program
    {
        static void Main(string[] args){
            string[] unidades = { "Dólar", "Euro", "Libra Esterlina", "Yen Japonés", "Peso Mexicano", "Franco Suizo", "Dólar Canadiense", "Dólar Australiano", "Yuan Chino", "Rupia India" };

            double [,] conversiones = {
                {1, 0.85, 0.75, 110, 20, 0.92, 1.25, 1.35, 6.5, 74},
                {1.18, 1, 0.88, 129, 23.53, 1.08, 1.47, 1.59, 7.65, 87.06},
                {1.33, 1.14, 1, 146.67, 26.67, 1.23, 1.67, 1.80, 8.67, 99.33},
                {0.009, 0.0077, 0.0068, 1, 0.18, 0.0084, 0.011, 0.012, 0.059, 0.68},
                {0.05, 0.0425, 0.0375, 5.5, 1, 0.046, 0.0625, 0.0675, 0.325, 3.7},
                {1.09, 0.93, 0.81, 120, 21.74, 1, 1.36, 1.47, 6.95, 80.43},
                {0.80, 0.68, 0.60, 88, 16, 0.74, 1, 1.08, 5.2, 60},
                {0.74, 0.63, 0.56, 81.48, 14.81, 0.68, 0.93, 1, 4.81, 55},
                {0.15, 0.13, 0.12, 17, 3.08, 0.14, 0.19, 0.21, 1, 11.38},
                {0.014, 0.0115, 0.010, 1.47, 0.27, 0.0124, 0.017, 0.018, 0.088, 1}
            };
           

        }
    }
}
