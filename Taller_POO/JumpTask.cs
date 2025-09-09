using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    public class JumpTask : Task
    {
        private Agent _agent;
        private float _height;
        private int _duration; // en ms

        public JumpTask(Agent agent, float height, int duration)
        {
            _agent = agent;
            _height = height;
            _duration = duration;
        }

        public override bool Execute()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{_agent.Name} está saltando...");
            Console.ResetColor();

            int steps = 10;
            int stepTime = _duration / steps;

            for (int i = 0; i <= steps; i++)
            {
                double progress = (double)i / steps;
                double y = Math.Sin(progress * Math.PI) * _height;
                Console.WriteLine($"Posición: {_agent.Position} | Altura: {y:F2}");
                Thread.Sleep(stepTime);
            }

            Console.WriteLine($"{_agent.Name} terminó el salto.\n");
            return true;
        }
    }
}
