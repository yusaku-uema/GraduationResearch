using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TowerCont : MonoBehaviour
{
    // �G�����m���邽�߂̕ϐ�
    GameObject[] Enemys;
    GameObject nearestEnemy = null;
    GameObject oldNearestEnemy = null;
    float minDis = 1000f;
    public float Range = 100f;//�U���\�͈�


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        /************************
        * ��ԋ߂��G�����m
       ************************/
        minDis = 1000f;

        // FindGameObjectsWithTag�Ń^�O������Enemy��������GameObject�i�z��j�Ɋi�[
        Enemys = GameObject.FindGameObjectsWithTag("Enemy");

        // �^�O��(Enemy)�̃Q�[���I�u�W�F�N�g�S���ɑ΂��ď��Ԃɏ��������Ă���
        foreach (GameObject enemy in Enemys)
        {
            float disWk = Vector3.Distance(transform.position, enemy.transform.position);
            if (disWk <= Range && disWk < minDis)
            {
                minDis = disWk;
                nearestEnemy = enemy;
            }
        }
        // Enemy���X�V����Ă��ȂƂ���
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
