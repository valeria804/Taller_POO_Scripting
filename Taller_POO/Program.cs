using System;
using System.Collections.Generic;

namespace Taller_POO
{
    class Program
    {
        static void Main()
        {
            Agent agent = new Agent("IA-01", new Vector2D(0, 0));
            Vector2D objetivo = new Vector2D(30, 15);
            float stoppingDistance = 5.0f;

            Console.WriteLine("=== Simulación de Árbol de Comportamiento ===");

            // Tareas
            MoveToTask moveToTarget = new MoveToTask(agent, objetivo, 5f);
            WaitTask wait = new WaitTask(1500);
            JumpTask jump = new JumpTask(agent, 5f, 2000);

            // Sub-selector: Comprueba distancia antes de mover
            IsTargetInRangeSelector moveSelector = new IsTargetInRangeSelector(
                new List<Node> { moveToTarget },
                agent,
                objetivo,
                stoppingDistance
            );

            // Selector principal: o se mueve o salta
            Selector moveOrJump = new Selector(new List<Node> {
                moveSelector,
                jump
            });

            // Secuencia raíz: primero selector, luego esperar
            Sequence rootSequence = new Sequence(new List<Node> {
                moveOrJump,
                wait
            });

            Root root = new Root(rootSequence);

            // Loop infinito (patrullaje)
            while (true)
            {
                root.Execute();
            }
        }
    }
}

