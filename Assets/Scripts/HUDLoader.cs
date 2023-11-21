using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUDLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { //LoadSceneMode.Single 이 기본값
        SceneManager.LoadScene("Scenes/HUD",LoadSceneMode.Additive);
    }

}
 