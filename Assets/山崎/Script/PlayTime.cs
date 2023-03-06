using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayTime : MonoBehaviour
{
    public static float rnd;
    private float time;
    private float minite;
    private float second;
    private float msecond;
    [SerializeField] private Text text;
    [SerializeField] private GameObject Pose;
    // Start is called before the first frame update
    void Start()
    {
        rnd=0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Pose.activeSelf == false)
        {
            rnd += Time.deltaTime;
        }
        
        minite = rnd / 60;//•ª
        second = rnd % 60;//•b
        msecond = (second - Mathf.Floor(second)) * 100;//•b‚Ì‰º
        text.text = Mathf.Floor(minite).ToString("0") + ":" + Mathf.Floor(second).ToString("00") + ":" + Mathf.Floor(msecond).ToString("00");
    }
}
