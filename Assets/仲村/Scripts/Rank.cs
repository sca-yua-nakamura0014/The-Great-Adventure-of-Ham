using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rank : MonoBehaviour
{
    private float time = PlayTime.rnd;//�L�^
    [SerializeField] GameObject S;//�����NS
    [SerializeField] GameObject A;//�����NA
    [SerializeField] GameObject B;//�����NB
    [SerializeField] GameObject C;//�����NC

    // Start is called before the first frame update
    void Start()
    {
        Invoke("TimeRank", 0.35f);

    }

    // Update is called once per frame
    void Update()
    {


    }

    void TimeRank()
    {
        GetComponent<AudioSource>().Stop();
        if (time < 60.0f)//time��60�b�����Ȃ烉���NS
        {
            S.SetActive(true);
        }
        else if (time <= 75.0f)//time��75�b�ȉ��Ȃ烉���NA
        {
            A.SetActive(true);
        }
        else if (time <= 80.0f)//time��80�b�ȉ��Ȃ烉���NB
        {
            B.SetActive(true);
        }
        else//����ȊO�Ȃ烉���NC
        {
            C.SetActive(true);
        }

        Invoke("Sound", 1.0f);
    }

    void Sound()
    {
        GetComponent<AudioSource>().Play();
    }
}