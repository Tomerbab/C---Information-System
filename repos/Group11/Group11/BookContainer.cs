using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group11
{
    public class BookContainer
    {
        public Enum Name { get; set; }
        public string Description { get; set; }
        // for displaying in ComboBox
        public override string ToString() => Description;
    }
}
