using System;
using ScoreSystem;
using UnityEngine;

namespace ClickSystem
{
    public class ClickableComponent : MonoBehaviour
    {
        private Score _score;

        public void Construct(Score score)
        {
            _score = score;
        }
        private void OnMouseDown()
        {
           _score.AddScore();
        }
    }
}
