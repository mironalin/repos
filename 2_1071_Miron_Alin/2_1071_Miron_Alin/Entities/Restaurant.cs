using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1071_Miron_Alin.Entities
{
    [Serializable]
    public class Restaurant
    {
        public List<Waiter> Waiters { get; set; }

        public Restaurant() 
        {
            Waiters = new List<Waiter>();
        }
    }
}
