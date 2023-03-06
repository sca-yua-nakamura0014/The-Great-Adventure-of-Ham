using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    private Animator ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = gameObject.GetComponent<Animator>();//Animatorコンポーネントを設定
    }

    // Update is called once per frame
    void Update()
    {
        if(ResultMove.ran == 1)//値が１ならボールのアニメーションを動かす
        {
            ball.SetBool("ballBL", true);
            Invoke("Stop", 1.0f);//1秒たったらアニメーションを止める
            ResultMove.ran = 0;
        }
        
    }

    void Stop()
    {
        ball.SetBool("ballBL", false);
    }
}
