using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HUDKey : MonoBehaviour
{
    public Sprite hasKeySprite;
    public Sprite hasNoKeySprite;

    PlayerController player;
    Image image;

    // Start is called before the first frame update
    void Start()
    {
        // 플레이어 컴포넌트 미리 저장(캐싱; caching)
        player = FindObjectOfType<PlayerController>();

        // 이미지 컴포넌트 미리 저장
        image = GetComponent<Image>();

        // 열쇠 GameObject의 존재를 검사
        GameObject key = GameObject.FindGameObjectWithTag("Key");
        if (key == null)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            return;
        }
        if (player.hasKey)
        {
            image.sprite = hasKeySprite;
        }
        else
        {
            image.sprite = hasNoKeySprite;
        }
    }
}
