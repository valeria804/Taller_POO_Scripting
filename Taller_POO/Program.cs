namespace Taller_POO
{
    class Program
    {
        static void Main()
        {
            Agent agent = new Agent("IA-01", new Vector2D(0, 0));
            Vector2D objetivo = new Vector2D(30, 15);
            Vector2D home = new Vector2D(0, 0);
            float stoppingDistance = 1.0f;

            Console.WriteLine("=== Simulación de Árbol de Comportamiento ===");

            // Árbol: Secuencia -> Selector (Check distancia) -> MoveTo -> Wait -> MoveTo(home)
            MoveToTask moveToTarget = new MoveToTask(agent, objetivo, 5f);
            MoveToTask moveToHome = new MoveToTask(agent, home, 5f);
            WaitTask wait = new WaitTask(1500);

            IsTargetInRangeSelector shouldMoveSelector = new IsTargetInRangeSelector(
                new List<Node> { moveToTarget },
                agent,
                objetivo,
                stoppingDistance
            );

            Sequence rootSequence = new Sequence(new List<Node> {
                shouldMoveSelector,
                wait,
                moveToHome,
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

