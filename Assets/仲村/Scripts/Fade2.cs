using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade2 : MonoBehaviour
{
    private Animator anim;
    //public int f;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Sleep.fade != 0|| confusion.fade != 0)//スリープと混乱ならフェードを動かす
        {
            Debug.Log(Sleep.fade);
            Debug.Log(confusion.fade);
            anim.SetBool("Fade2BL", true);

        }
        else
        {
            anim.SetBool("Fade2BL", false);
        }
        //Debug.Log(f)
    }
}
