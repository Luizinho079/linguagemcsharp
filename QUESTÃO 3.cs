using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AREADORETANGULO
{
    class Program
    {
        static void Main(string[] args)
        {
            float areaDo_Retangulo(float base, float altura) {
                float calculo = base * altura;
                float perimetro = (base * 2) + (altura * 2);
                return printf("Area do Retangulo = %f \n Perimetro %f", calculo, perimetro);
            }
        }
    }
}
