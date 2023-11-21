
using UnityEngine;
using UnityEngine.SceneManagement;

public class Objective : MonoBehaviour
{

    public string nextLevelName;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player")) // �ν������� �±�
        {
            Debug.Log("�÷��̾ ��ǥ��(Objective)�� �浹�Ͽ����ϴ�.");
            //Debug.Log(SceneManager.GetActiveScene().buildIndex);
            
            
            PlayerPrefs.SetInt(nextLevelName, 1);

            SceneManager.LoadScene(nextLevelName);
            
            
        }
    }
}
