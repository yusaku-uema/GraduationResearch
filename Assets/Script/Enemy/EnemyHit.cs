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

    // Õ“Ë‚µ‚½uŠÔ‚ÉŒÄ‚Î‚ê‚é  
    void OnCollisionEnter(Collision collision)
    {
        // “G‚ÉÕ“Ë‚µ‚½‚à‚Ì‚ª’e(tag:bullet01)‚¾‚Á‚½ê‡A’e‚ğíœ
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("OnColider1");
            Destroy(collision.gameObject, .1f);

        }
    }
}
