
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{

    Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        Debug.Log("Quit 버튼이 눌렸습니다.");

        Application.Quit();
    }

}
