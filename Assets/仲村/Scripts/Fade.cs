using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
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
        if (teleport.Fade != 0)//テレポートならフェードを動かす
        {
            //Debug.Log(Sleep.fade);
            //Debug.Log(confusion.fade);
            Debug.Log(teleport.Fade);
            anim.SetBool("FadeBL", true);
            
        }
        else
        {
            anim.SetBool("FadeBL", false);
        }
        //Debug.Log(f);

    }
}