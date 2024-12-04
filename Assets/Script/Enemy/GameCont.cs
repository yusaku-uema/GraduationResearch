using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameCont : MonoBehaviour
{
    // �G�o���̂��߂̕ϐ�
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
       * �G�̏o�����R���g���[��
      ************************/
        // �G���^�O�Ŏ擾
        Enemys = GameObject.FindGameObjectsWithTag("Enemy");
        EnemyWk = Enemys.Length;

        // �G���o������n�_���w��
        Vector3 vec1 = StartPoint.position;

        if (EnemyWk < EnemyNum)
        {
            GameObject EnemyObj = Instantiate(Enemy, vec1, Quaternion.identity) as GameObject;
            agent = EnemyObj.GetComponent<NavMeshAgent>();
            agent.SetDestination(GolePoint.position);
        }
    }
}
