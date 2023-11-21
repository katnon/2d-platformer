using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDProjectile : MonoBehaviour
{

    PlayerController player;
    Image image;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        image = GetComponent<Image>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            return;
        }

        if (player.hasProjectile)
        {
            image.enabled = true;
        }
        else
        {
            image.enabled = false;  
        }
    }
}
