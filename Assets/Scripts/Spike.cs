using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player")) // �ν������� �±�
        {
            Debug.Log("�÷��̾ ���ÿ� �浹�Ͽ����ϴ�.");
            Debug.Log(SceneManager.GetActiveScene().buildIndex);

            GameManager.Instance.GameOver();
        }
    }

}
