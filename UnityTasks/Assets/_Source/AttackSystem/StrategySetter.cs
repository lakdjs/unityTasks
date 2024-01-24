using System;
using UnityEngine;
using UnityEngine.UI;

namespace AttackSystem
{
    public class StrategySetter : MonoBehaviour
    {
        [SerializeField] private Button buttonFirstAttack;
        [SerializeField] private Button buttonSecondAttack;
        [SerializeField] private Button buttonThirdAttack;
        private AttackPerformer _attackPerformer;

        public void Construct(AttackPerformer attackPerformer)
        {
            _attackPerformer = attackPerformer;
            SetStrategyToContext(new AttackStrategy1());
        }

        private void Awake()
        {
            SetAttackToButton(buttonFirstAttack, new AttackStrategy1());
            SetAttackToButton(buttonSecondAttack, new AttackStrategy2());
            SetAttackToButton(buttonThirdAttack, new AttackStrategy3());
        }

        private void SetAttackToButton(Button button, IAttackStrategy strategy)
        {
            button.onClick.AddListener(() => SetStrategyToContext(strategy)); 
        }

        private void SetStrategyToContext(IAttackStrategy strategy)
        {
            _attackPerformer.SetStrategy(strategy);
        }
    }
}
