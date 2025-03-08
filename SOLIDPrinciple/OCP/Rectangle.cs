using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.OCP
{

    /*"Open for extension" means we must design our module/class so that the new functionality can be added only when new requirements are generated. 
        "Closed for modification" means we have already developed a class, 
        and it has gone through unit testing.We should then not alter it until we find bugs.As it says, a class should be open for extensions; we can use inheritance.*/
    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Height * Width;
        }
    }
}
