using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestShooting : MonoBehaviour
{
    // 弾のGameObject
    public GameObject bullet;

    // 弾丸発射点のGameObjectのTransfom
    public Transform muzzle;

    public float speed = 10000; // 弾丸の速度
    public float timeOut = 0; // 時間を打つ間隔を指定
    private float timeElapsed; //経過時間を格納


    // 敵を検知するための変数
    GameObject[] Enemys;
    GameObject nearestEnemy = null;
    GameObject oldNearestEnemy = null;
    float minDis = 500f;
    public float Range = 100f;//攻撃可能範囲


    void Start()
    {

    }

    void Update()
    {

        /************************
       * 一番近い敵を検知
      ************************/
        minDis = 500f;

        // FindGameObjectsWithTagでタグ名からEnemyを検索しGameObject（配列）に格納
        Enemys = GameObject.FindGameObjectsWithTag("Enemy");

        // タグ名(Enemy)のゲームオブジェクト全部に対して順番に処理をしていく
        foreach (GameObject enemy in Enemys)
        {
            float disWk = Vector3.Distance(transform.position, enemy.transform.position);
            if (disWk <= Range && disWk < minDis)
            {
                minDis = disWk;
                nearestEnemy = enemy;
            }
        }
        // Enemyが更新されていなときは
        if (nearestEnemy == oldNearestEnemy)
        {
            // minDis = 1000f;
        }

        if (nearestEnemy != null)
        {
            shooting();
            oldNearestEnemy = nearestEnemy;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(nearestEnemy.transform.position - transform.position), 1.9f);
        }


    }

        
    private void shooting()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            // 弾丸の複製(プレファブした弾GObjectを)
            GameObject bullets = Instantiate(bullet) as GameObject;

            // 変数：弾の力
            Vector3 force;

            // 弾丸のはじめ位置を調整
            bullets.transform.position = muzzle.position;
            // foceを計算する
            force = this.gameObject.transform.forward * speed;

            // Rigidbodyに力を加える
            bullets.GetComponent<Rigidbody>().AddForce(force);

            timeElapsed = 0.0f;
        }
    }

}
