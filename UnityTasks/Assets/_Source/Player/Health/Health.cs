using System;

namespace Player.Health
{
    public class Health
    {
        public event Action<int> OnHealthChanged; 
        public event Action<int> OnPlayerDied;
        private int _hp;
        private int _startHp;
        public Health(int hpValue)
        {
            _startHp = hpValue;
        }
        public void AddHp(int value)
        {
            _hp -= value;
            OnHealthChanged?.Invoke(_hp);
            if (_hp <= 0)
            {
                OnPlayerDied?.Invoke(_hp);
            }
        }

        public void StartHp()
        {
            _hp = _startHp;
            OnHealthChanged?.Invoke(_startHp);
        }
    }
}
