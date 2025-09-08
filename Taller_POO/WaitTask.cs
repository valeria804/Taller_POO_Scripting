using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    public class WaitTask : Task
    {
        private int _ms;
        public WaitTask(int ms) => _ms = ms;

        public override bool Execute()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Esperando {_ms / 1000.0f} segundos...");
            Console.ResetColor();

            Thread.Sleep(_ms);
            return true;
        }
    }
}
