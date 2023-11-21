
using UnityEngine;
using UnityEngine.SceneManagement;

public class Objective : MonoBehaviour
{

    public string nextLevelName;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player")) // 인스펙터의 태그
        {
            Debug.Log("플레이어가 목표물(Objective)과 충돌하였습니다.");
            //Debug.Log(SceneManager.GetActiveScene().buildIndex);
            
            
            PlayerPrefs.SetInt(nextLevelName, 1);

            SceneManager.LoadScene(nextLevelName);
            
            
        }
    }
}
