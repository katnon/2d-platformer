using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float movespeed = 10f;
    public float rotateSpeed = 800f;
    public float timeToBeDestroyed = 5f;

    Vector3 dircetion;
    Rigidbody2D rigidbody2D;
    public void Fire(Vector3 direction)
    {
        this.dircetion = direction;

        GameObject.Destroy(gameObject,timeToBeDestroyed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy")) // 인스펙터의 태그
        {
            Debug.Log("발사체가 적(Enemy)과 충돌하였습니다.");

            GameObject.Destroy(collision.collider.gameObject);
            GameObject.Destroy(gameObject);
        }
        else if (collision.collider.CompareTag("Platform")) // 인스펙터의 태그
        {
            Debug.Log("발사체가 플랫폼(Platforms)과 충돌하였습니다.");

            GameObject.Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (GameManager.Instance.State == GameManager.GameState.Paused)
        {
            return;
        }

        transform.Rotate(new Vector3(0,0,rotateSpeed));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody2D.velocity = dircetion * movespeed;
    }
}
