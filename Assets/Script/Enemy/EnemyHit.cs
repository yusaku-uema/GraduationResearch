using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit: MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    // �Փ˂����u�ԂɌĂ΂��  
    void OnCollisionEnter(Collision collision)
    {
        // �G�ɏՓ˂������̂��e(tag:bullet01)�������ꍇ�A�e���폜
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("OnColider1");
            Destroy(collision.gameObject, .1f);

        }
    }
}
