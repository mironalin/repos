using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1071_Miron_Alin.Entities
{
    [Serializable]
    public class Waiter : IComparable<Waiter>
    {
        public string Name { get; set; }
        public int TablesServed { get; set; }
        public DateTime StartTime { get; set; }
        public Waiter()
        {
            StartTime = DateTime.Now;
        } 

        public Waiter(string name, int tablesServed, DateTime startTime) : this()
        {
            Name = name;
            TablesServed = tablesServed;
            StartTime = startTime;
        }

        public int CompareTo(Waiter other)
        {
            return TablesServed.CompareTo(other.TablesServed);
        }
    }
}
