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
        transform.Rotate(Vector3.up * Time.deltaTime * 180f, Space.World); // �ϳ��� �������� ������Ʈ�Ǵµ� �ɸ��½ð�
        transform.Translate(Vector3.forward * Time.deltaTime * 5f, Space.World);

        // space. world -> ���� ��ǥ ���� self -> �� ��ǥ ����
    }
}
