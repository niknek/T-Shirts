using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNektarios.Store
{
    public class TShirt
    {
        public string Color { get; set; }
        public string Fabric { get; set; }
        public string Size { get; set; }

        

        public TShirt(string color , string fabric , string size)
        {
            Color = color;
            Fabric = fabric;
            Size = size;
        }

        
        public int CalculatePrice()
        {
            if (this.Fabric == "Cotton")
                return 25;
            else if (this.Fabric == "Polyester")
                return 23;
            else if (this.Fabric == "Cashmere")
                return 38;
            else if (this.Fabric == "Wool")
                return 21;
            else if (this.Fabric == "Rayon")
                return 20;
            else if (this.Fabric == "Linen")
                return 15;
            else if (this.Fabric == "Silk")
                return 19;
            else
                return 0;

        }

      
    }
}
