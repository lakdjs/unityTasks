using TMPro;
using UnityEngine;

namespace Player.Health
{
    public class HealthView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI hpText;

        public void UpdateHpText(int hp)
        {
            hpText.text = $"hp {hp}";
            Debug.Log($"hp {hp}");
        }
    }
}
