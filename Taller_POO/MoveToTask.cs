using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    public class MoveToTask : Task
    {
        private Agent _agent;
        private Vector2D _target;
        private float _step;

        public MoveToTask(Agent agent, Vector2D target, float step = 2.0f)
        {
            _agent = agent;
            _target = target;
            _step = step;
        }

        public override bool Execute()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Moviendo {_agent.Name} hacia {_target}...");
            Console.ResetColor();

            _agent.MoveTowards(_target, _step);
            Console.WriteLine($"Nueva posición: {_agent.Position}");

            return Vector2D.Distance(_agent.Position, _target) < 0.1f;
        }
    }
}
