using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCont : MonoBehaviour
{
    // �����悤�p�[�e�B�N
    public GameObject explosion;

    public float life_time = 2.5f;
    private float time = 0f;

    // Use this for initialization
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > life_time)
        {
            Destroy(gameObject);
        }
    }

   


    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnTrriger1");
        // ���������ꍇ�G���폜
        if (collision.gameObject.tag == "Enemy")
        {
            //Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(collision.gameObject, .1f);
        }
    }
}
