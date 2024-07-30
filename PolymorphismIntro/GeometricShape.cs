using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIntro
{
    public abstract class GeometricShape
    {
        private float _height;
        private float _width;

        public GeometricShape(float height, float width)
        {
            Height = height;
            Width = width;
        }

        public float Height { get => _height; set => _height = value; }
        public float Width { get => _width; set => _width = value; }

        public virtual void CalculateArea()
        {
            Console.WriteLine("Alan hesaplandı.");
        }
    }
}
