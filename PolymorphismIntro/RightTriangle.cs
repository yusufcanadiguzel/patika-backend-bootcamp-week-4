using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIntro
{
    internal class RightTriangle : GeometricShape
    {
        public RightTriangle(float height, float width) : base(height, width)
        {
        }

        public override void CalculateArea()
        {
            //dik ucgen alani formulu: yukseklik x genislik
            float result = (this.Height * this.Width) / 2;

            //sonucu ekrana yazdirir
            Console.WriteLine($"Dik Üçgenin Alanı Formulü: (Yükseklik x Genişlik) / 2");
            Console.WriteLine($"{this.Height} x {this.Width} = {result}");
        }
    }
}
