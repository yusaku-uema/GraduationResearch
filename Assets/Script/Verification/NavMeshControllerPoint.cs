using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshControllerPoint : MonoBehaviour
{
    NavMeshAgent agent;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();//�A�^�b�`����Ă���NavMeshAgent���擾
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            // �}�E�X�ŃN���b�N�����ӏ��̃Q�[�����ł̍��W�����߂܂��B
            RaycastHit hit;
            Ray ray;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100f))
            {

                agent.destination = hit.point;
            }
        }
    }
}
