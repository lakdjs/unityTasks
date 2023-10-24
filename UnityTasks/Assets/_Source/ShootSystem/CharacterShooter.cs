using UnityEngine;

namespace ShootSystem
{
    public class CharacterShooter : MonoBehaviour
    {
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private Transform firePoint;
        
        public void Shoot()
        {
            Instantiate(bulletPrefab, firePoint);
        }
    }
}
