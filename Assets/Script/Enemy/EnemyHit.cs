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

    // 衝突した瞬間に呼ばれる  
    void OnCollisionEnter(Collision collision)
    {
        // 敵に衝突したものが弾(tag:bullet01)だった場合、弾を削除
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("OnColider1");
            Destroy(collision.gameObject, .1f);

        }
    }
}
