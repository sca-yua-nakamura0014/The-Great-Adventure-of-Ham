using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonMove : MonoBehaviour
{
    private Animator move;
    // Start is called before the first frame update
    void Start()
    {
        move = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Touch()//ボタンに触れているならアニメーションを動かす
    {
        move.SetBool("StartButtonBL", true);
    }

    public void Stop()//ボタンから離れたならアニメーションを止める
    {
        move.SetBool("StartButtonBL", false);

    }
}
