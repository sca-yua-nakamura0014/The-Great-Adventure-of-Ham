using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMove : MonoBehaviour
{
    private Animator cat;
    // Start is called before the first frame update
    void Start()
    {
        cat = gameObject.GetComponent<Animator>();//Animatorコンポーネントを設定
    }

    // Update is called once per frame
    void Update()
    {
        if (ResultMove.ran == 3)//値が3なら猫のアニメーションを動かす
        {
            cat.SetBool("CatBL", true);
            Invoke("Stop", 1.0f);//1秒たったらアニメーションを止める
            ResultMove.ran = 0;
        }

    }

    void Stop()
    {
        cat.SetBool("CatBL", false);
    }
}
