
using UnityEngine;

public class Door : MonoBehaviour
{

    public Sprite openedDoorSprite;

    SpriteRenderer spriteRenderer;
    BoxCollider2D boxCollider2D;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }




    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player")) // 인스펙터의 태그
        {
            Debug.Log("플레이어가 문(Door)과 충돌하였습니다.");

            
            PlayerController player = collision.collider.gameObject.GetComponent<PlayerController>();
            if (player == null)
            {
                return;
            }
            
            
            
            if (player.hasKey)
            {
                player.hasKey = false;

                spriteRenderer.sprite = openedDoorSprite;
                boxCollider2D.enabled = false;
            
            }
            

            
            
        }
    }
}
