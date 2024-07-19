using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationIntro
{
    internal class Car
    {
        //fieldlar
        private string? _brand;
        private string? _model;
        private string? _color;
        private int _doorCount;

        //proplar
        public string? Brand
        {
            get => _brand;
            set => _brand = value;
        }

        public string? Model
        {
            get => _model;
            set => _model = value;
        }

        public string? Color
        {
            get => _color;
            set => _color = value;
        }

        public int DoorCount
        {
            get => _doorCount;
            set
            {
                //atanmak istenen deger 2 ya da 4ten farkli bir degerse hata verir ve -1 olarak atama yapar
                if ((value == 2) || (value == 4))
                {
                    _doorCount = value;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız.");
                    _doorCount = -1;
                }
            }
        }
    }
}
