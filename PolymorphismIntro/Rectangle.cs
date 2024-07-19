using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIntro
{
    internal class Rectangle : GeometricShape
    {
        public Rectangle(float height, float width) : base(height, width)
        {
        }

        public override void CalculateArea()
        {
            //dikdortgenin alani formulu: yukseklik x genislik
            float result = this.Height * this.Width;

            //sonucu ekrana yazdirir
            Console.WriteLine($"Dikdörtgenin Alanı Formulü: Yükseklik x Genişlik");
            Console.WriteLine($"{this.Height} x {this.Width} = {result}");
        }
    }
}
