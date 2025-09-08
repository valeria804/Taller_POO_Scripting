using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    public class Selector : Composite
    {
        public Selector(List<Node> children) : base(children) { }

        public virtual bool Check() => true;

        public override bool Execute()
        {
            if (!Check())
            {
                Console.WriteLine("--> Selector falló (condición).");
                return false;
            }

            foreach (Node child in children)
            {
                if (child.Execute())
                {
                    Console.WriteLine("--> Selector exitoso.");
                    return true;
                }
            }
            Console.WriteLine("--> Selector falló.");
            return false;
        }
    }
}
