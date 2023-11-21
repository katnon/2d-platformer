using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum GameState
    {
        Running = 0,
        Paused = 1
    }


    static GameManager _instance;

    //�̱���(Singleton) ����    
    // �� ���� 2�� �̻� ������ �ʵ��� ������Ű��(���ѽ�Ű��) ���� 

    public static GameManager Instance
    {
        // ������Ƽ(Property)
        get
        {
            _instance = FindObjectOfType<GameManager>();

            if(_instance == null)
            {
                GameObject go = new GameObject("GameManager");
                _instance = go.AddComponent<GameManager>();
            }

            return _instance;   
        }
    }

    public GameState State
    {
        // get: �б� ���� ������Ƽ
        get
        {
            return state;
        }
    }
    inGameHUD hud;
    [SerializeField] GameState state;

    void Start()
    {
        if(_instance == null)
        {
            _instance = this;
        }
        // �ߺ��� GameManager�� �����ϴ� ���. �� gameObject�� �ı���
        else
        {
            GameObject.Destroy(gameObject);
        }
        hud = FindObjectOfType<inGameHUD>();

    }

    public void ResumeGame()
    {
        state = GameState.Running;
        hud.ClosePauseMenu();
        Time.timeScale = 1f;
    }

    public void OpenMenu()
    {
        ResumeGame();
        SceneManager.LoadScene("Scenes/Menu");


    }
    public void QuitGame()
    {
        Application.Quit();
    }



    public void GameOver()
    {
        Debug.Log("���� ���� �Ǿ����ϴ�.");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Update()
    {
        //ESC�� ��������� ����
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (state == GameState.Running)
            {
                PauseGame();
                
            }
            else
            {
                ResumeGame();
            }
        }
            
        
    }

    void PauseGame()
    {
        state = GameState.Paused;
        hud.OpenPauseMenu();
        Time.timeScale = 0f;
    }


}
