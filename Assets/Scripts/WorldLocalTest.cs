using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldLocalTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 180f, Space.World); // 하나의 프레임이 업데이트되는데 걸리는시간
        transform.Translate(Vector3.forward * Time.deltaTime * 5f, Space.World);

        // space. world -> 월드 좌표 기준 self -> 내 좌표 기준
    }
}
