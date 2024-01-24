using UnityEngine;

namespace AttackSystem
{
    public class AttackPerformer
    {
        private IAttackStrategy _attackStrategy;

        public void SetStrategy(IAttackStrategy attackStrategy)
        {
            _attackStrategy = attackStrategy;
        }

        public void PerformAttack()
        {
            _attackStrategy.Attack();
        }
    }
}
