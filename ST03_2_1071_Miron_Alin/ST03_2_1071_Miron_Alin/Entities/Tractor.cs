using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST03_2_1071_Miron_Alin.Entities
{
    [Serializable]
    public class Tractor : IComparable<Tractor>
    {
        public string Brand { get; set; }
        public int Horsepower { get; set; }
        public double Price { get; set; }

        public Tractor() { }

        public Tractor(string brand, int horsepower, double price)
        {
            Brand = brand;
            this.Horsepower = horsepower;
            this.Price = price;
        }

        public int CompareTo(Tractor other)
        {
            return Horsepower.CompareTo(other.Horsepower);
        }
    }
}
