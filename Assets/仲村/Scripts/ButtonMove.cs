using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMove : MonoBehaviour
{
    private Animator move;
    // Start is called before the first frame update
    void Start()
    {
        move = gameObject.GetComponent<Animator>();//Animatorコンポーネントを設定
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Touch()//ボタンに触れているならアニメーションを動かす
    {
        move.SetBool("ButtonBL", true);
    }

    public void Stop()//ボタンから離れたならアニメーションを止める
    {
        move.SetBool("ButtonBL", false);
    }
}
