namespace Player.Health
{
    public class HealthController
    {
        private Health _health;
        private HealthView _healthView;

        public HealthController(Player.Health.Health health, HealthView healthView)
        {
            _healthView = healthView;
            _health = health;
        }

        public void Bind()
        {
            _health.OnHealthChanged += _healthView.UpdateHpText;
        }

        public void Expose()
        {
            _health.OnHealthChanged -= _healthView.UpdateHpText;
        }
    }
}
