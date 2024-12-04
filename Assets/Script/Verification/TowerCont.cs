using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TowerCont : MonoBehaviour
{
    // 敵を検知するための変数
    GameObject[] Enemys;
    GameObject nearestEnemy = null;
    GameObject oldNearestEnemy = null;
    float minDis = 1000f;
    public float Range = 100f;//攻撃可能範囲


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        /************************
        * 一番近い敵を検知
       ************************/
        minDis = 1000f;

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
            oldNearestEnemy = nearestEnemy;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(nearestEnemy.transform.position - transform.position), 1.9f);
        }

    }
}
