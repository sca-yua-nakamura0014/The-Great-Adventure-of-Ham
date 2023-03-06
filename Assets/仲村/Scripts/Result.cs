using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Result : MonoBehaviour
{
    public static int count =0;
    void Start()
    {
       
    }
    void Update()
    {

    }

    public void OnClickResultButton()
    {
        SceneManager.LoadScene("Result");//ƒŠƒUƒ‹ƒg‰æ–Ê‚ÖˆÚ“®
        count++;
    }
}
