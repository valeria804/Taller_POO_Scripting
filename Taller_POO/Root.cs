using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Taller_POO
{
    public class Root : Node
    {
        public Root(Node child) => children.Add(child);

        public override bool Execute()
        {
            if (children.Count == 1)
            {
                return children[0].Execute();
            }
            
                Console.WriteLine("Error: Root sin hijo.");
            return false;
        }
    }
}
