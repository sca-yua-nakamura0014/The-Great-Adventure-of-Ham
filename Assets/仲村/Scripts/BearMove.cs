using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearMove : MonoBehaviour
{
    private Animator bear;
    // Start is called before the first frame update
    void Start()
    {
        bear = gameObject.GetComponent<Animator>();//Animatorコンポーネントを設定
    }

    // Update is called once per frame
    void Update()
    {
        if (ResultMove.ran == 2)//値が2なら熊のアニメーションを動かす
        {
            bear.SetBool("brBL", true);
            Invoke("Stop", 1.0f);//1秒たったらアニメーションを止める
            ResultMove.ran = 0;
        }

    }

    void Stop()
    {
        bear.SetBool("brBL", false);
    }
}