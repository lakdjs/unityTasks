using System;

namespace ScoreSystem
{
    public class Score
    {
        private const int StartValue = 5;
        private const int EndValue = 0;
        
        private int _addingScore = 1;
        private int _score;

        public Action<int> OnScoreChange;
        public void ResetScore()
        {
            _score = EndValue;
            OnScoreChange?.Invoke(_score);
        }
        public void SetUpScore()
        {
            _score = StartValue;
            OnScoreChange?.Invoke(_score);
        }

        public void AddScore(int value)
        {
            _score += value;
            OnScoreChange?.Invoke(_score);
        }
    }
}
