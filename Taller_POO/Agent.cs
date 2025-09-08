using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    public class Agent
    {
        public string Name { get; set; }
        public Vector2D Position { get; set; }

        public Agent(string name, Vector2D position)
        {
            Name = name;
            Position = position;
        }

        // Método que mueve al agente hacia el objetivo
        public void MoveTowards(Vector2D target, float step)
        {
            float dx = target.X - Position.X;
            float dy = target.Y - Position.Y;
            float dist = (float)Math.Sqrt(dx * dx + dy * dy);

            if (dist < step)
            {
                Position.X = target.X;
                Position.Y = target.Y;
            }
            else
            {
                Position.X += (dx / dist) * step;
                Position.Y += (dy / dist) * step;
            }
        }
    }
}
