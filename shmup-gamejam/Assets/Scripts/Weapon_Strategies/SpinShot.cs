using UnityEngine;

namespace Shmup
{
    [CreateAssetMenu(fileName = "SpinShot", menuName = "Shmup/WeaponStrategy/SpinShot")]
    public class SpinShot : WeaponStrategy
    {
        [SerializeField] float spreadAngle = 15f;

        public override void Fire(Transform firePoint, LayerMask layer)
        {
            for (int i = 0; i < 3; i++)
            {
                var projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

                projectile.transform.Rotate(0f, 0f, spreadAngle * (i - 1));
                projectile.layer = layer;

                var projectileComponent = projectile.GetComponent<Projectile>();
                projectileComponent.SetSpeed(projectileSpeed);
                projectileComponent.shooter = firePoint.parent.gameObject;
                projectileComponent.SetDamageTag(firePoint.CompareTag("Player") ? "Enemy" : "Player");

                Destroy(projectile, projectileLifetime);
            }
        }
    }
}
