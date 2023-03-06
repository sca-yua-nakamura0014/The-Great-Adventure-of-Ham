using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintButtonMove : MonoBehaviour
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
        move.SetBool("HintBL", true);
    }

    public void Stop()//ボタンから離れたならアニメーションを止める
    {
        move.SetBool("HintBL", false);

    }
}
