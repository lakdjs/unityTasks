using System;
using AttackSystem;
using InputSystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private InputListener inputListener;
        [SerializeField] private StrategySetter strategySetter;
        private AttackPerformer _attackPerformer;

        private void Awake()
        {
            SetApp();
        }

        private void SetApp()
        {
            _attackPerformer = new AttackPerformer();
            inputListener.Construct(_attackPerformer);
            strategySetter.Construct(_attackPerformer);
        }
    }
}
