using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player")) // 인스펙터의 태그
        {
            Debug.Log("플레이어가 가시와 충돌하였습니다.");
            Debug.Log(SceneManager.GetActiveScene().buildIndex);

            GameManager.Instance.GameOver();
        }
    }

}
