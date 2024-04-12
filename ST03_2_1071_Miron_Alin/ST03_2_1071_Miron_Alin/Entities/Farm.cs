using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST03_2_1071_Miron_Alin.Entities
{
    [Serializable]
    public class Farm
    {
        public List<Tractor> Tractors { get; set; }

        public Farm()
        {
            Tractors = new List<Tractor>();
        }
    }
}
