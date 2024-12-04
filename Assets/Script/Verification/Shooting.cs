using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestShooting : MonoBehaviour
{
    // �e��GameObject
    public GameObject bullet;

    // �e�۔��˓_��GameObject��Transfom
    public Transform muzzle;

    public float speed = 10000; // �e�ۂ̑��x
    public float timeOut = 0; // ���Ԃ�łԊu���w��
    private float timeElapsed; //�o�ߎ��Ԃ��i�[


    // �G�����m���邽�߂̕ϐ�
    GameObject[] Enemys;
    GameObject nearestEnemy = null;
    GameObject oldNearestEnemy = null;
    float minDis = 500f;
    public float Range = 100f;//�U���\�͈�


    void Start()
    {

    }

    void Update()
    {

        /************************
       * ��ԋ߂��G�����m
      ************************/
        minDis = 500f;

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
            // �e�ۂ̕���(�v���t�@�u�����eGObject��)
            GameObject bullets = Instantiate(bullet) as GameObject;

            // �ϐ��F�e�̗�
            Vector3 force;

            // �e�ۂ̂͂��߈ʒu�𒲐�
            bullets.transform.position = muzzle.position;
            // foce���v�Z����
            force = this.gameObject.transform.forward * speed;

            // Rigidbody�ɗ͂�������
            bullets.GetComponent<Rigidbody>().AddForce(force);

            timeElapsed = 0.0f;
        }
    }

}
