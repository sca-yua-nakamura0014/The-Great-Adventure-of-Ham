using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Try",10.0f);//10秒後にゲーム画面へ移動
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Try()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
