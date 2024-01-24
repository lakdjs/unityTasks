using System;
using AttackSystem;
using UnityEngine;


namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private KeyCode attackCode;
        private AttackPerformer _attackPerformer;

        public void Construct(AttackPerformer attackPerformer)
        {
            _attackPerformer = attackPerformer;
        }

        private void Update()
        {
            CheckForAttack();
        }

        private void CheckForAttack()
        {
            if (Input.GetKeyDown(attackCode))
            {
                Debug.Log("q");
                _attackPerformer.PerformAttack();
            }
        }
    }
}
