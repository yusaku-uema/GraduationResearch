using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameCont : MonoBehaviour
{
    // 敵出現のための変数
    public GameObject Enemy;
    public int EnemyNum;
    int EnemyWk;
    GameObject[] Enemys;
    public Transform GolePoint;
    public Transform StartPoint;
    NavMeshAgent agent;

    // Use this for initialization
    void Start()
    {
        EnemyWk = 0;
    }

    // Update is called once per frame
    void Update()
    {
        /************************
       * 敵の出現をコントロール
      ************************/
        // 敵をタグで取得
        Enemys = GameObject.FindGameObjectsWithTag("Enemy");
        EnemyWk = Enemys.Length;

        // 敵が出現する地点を指定
        Vector3 vec1 = StartPoint.position;

        if (EnemyWk < EnemyNum)
        {
            GameObject EnemyObj = Instantiate(Enemy, vec1, Quaternion.identity) as GameObject;
            agent = EnemyObj.GetComponent<NavMeshAgent>();
            agent.SetDestination(GolePoint.position);
        }
    }
}
