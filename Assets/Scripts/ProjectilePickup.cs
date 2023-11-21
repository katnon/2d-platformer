
using UnityEngine;

public class ProjectilePickup : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player")) // 인스펙터의 태그
        {
            Debug.Log("플레이어가 발사체(Projectile Pickup)와 충돌하였습니다.");

            PlayerController player = collision.collider.gameObject.GetComponent<PlayerController>();
            player.hasProjectile = true;

            GameObject.Destroy(gameObject);
        }
    }
}
