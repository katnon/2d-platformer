
using UnityEngine;

public class Key : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player")) // 인스펙터의 태그
        {
            Debug.Log("플레이어가 열쇠(key)와 충돌하였습니다.");
            
            //열쇠 획득 처리
            PlayerController player = collision.collider.gameObject.GetComponent<PlayerController>();
            player.hasKey = true;

            //열쇠 소멸 처리
            GameObject.Destroy(gameObject);  
        }
    }
}
