using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Nowtime : MonoBehaviour
{
    private float time;
    private float minite;
    private float second;
    private float msecond;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()//����̃^�C���𕶎��ɂ���
    {
        time = PlayTime.rnd;//����̃^�C��
        //Debug.Log(time);
        Text text = this.GetComponent<Text>();
        minite = time/60;//��
        second=time%60;//�b
        msecond = (second- Mathf.Floor(second))*100;//�b�̉�
        text.text = Mathf.Floor(minite).ToString("0")+":"+ Mathf.Floor(second).ToString("00") + ":" + Mathf.Floor(msecond).ToString("00");
        //Invoke("Sound", 1.0f);
    }

    void Sound()
    {
        GetComponent<AudioSource>().Play();
    }
}
