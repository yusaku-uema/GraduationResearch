using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Unity�G���W���̃V�[���Ǘ��v���O�����𗘗p����

public class TestTransition : MonoBehaviour
{
    public void test_button() //change_button�Ƃ������O�ɂ��܂�
    {
        SceneManager.LoadScene("Development");//second���Ăяo���܂�
    }
}
