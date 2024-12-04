using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Unityエンジンのシーン管理プログラムを利用する

public class TestTransition : MonoBehaviour
{
    public void test_button() //change_buttonという名前にします
    {
        SceneManager.LoadScene("Development");//secondを呼び出します
    }
}
