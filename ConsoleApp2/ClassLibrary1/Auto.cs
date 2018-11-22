using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Auto
    {
        private string Name;
        private string Mileage;
        private string Enginecapacity;
        private string Transmission;
        public int hasWarranty;
        public int price;

        public Auto(string Name, string Mileage, string Enginecapacity, string Transmission)
        {
            this.Name = Name;
            this.Mileage = Mileage;
            this.Enginecapacity = Enginecapacity;
            this.Transmission = Transmission;

        }

        public int Price
        {
            get { return price; }
            set
            {
                if (value > 0 && value < 500000)
                    price = value;
                else
                    throw new InvalidPriceException();
            }
        }
        public int HasWarranty
        {
            get { return hasWarranty; }
            set
            {
                if (value >= 0 && value <= 1)

                    hasWarranty = value;
                else
                    throw new InvalidhaswarrantyException();

            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Назва авто: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Авто: " + Name + ' ' + Mileage);
            Console.WriteLine("Объем двигателя: " + Enginecapacity);
            Console.WriteLine("Трансмиссия: " + Transmission);
            Console.WriteLine("Цiна: " + Price);
            Console.WriteLine(hasWarranty == 1 ? "Страховка имеется" : "Страховка отсутствует");

            Console.WriteLine();
        }
    }
}
