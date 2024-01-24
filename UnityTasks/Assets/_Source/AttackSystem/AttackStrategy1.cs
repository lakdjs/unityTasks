using UnityEngine;

namespace AttackSystem
{
    public class AttackStrategy1 : IAttackStrategy
    {
        public void Attack()
        {
            Debug.Log("First attack");
        }
    }
}
