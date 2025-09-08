using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    public class IsTargetInRangeSelector : Selector
    {
        private Agent _agent;
        private Vector2D _target;
        private float _validDistance;

        public IsTargetInRangeSelector(List<Node> children, Agent agent, Vector2D target, float distance)
            : base(children)
        {
            _agent = agent;
            _target = target;
            _validDistance = distance;
        }

        public override bool Check()
        {
            float dist = Vector2D.Distance(_agent.Position, _target);
            Console.WriteLine($"Chequeando distancia: {dist:F2} (umbral: {_validDistance})");
            return dist > _validDistance;
        }
    }

}
