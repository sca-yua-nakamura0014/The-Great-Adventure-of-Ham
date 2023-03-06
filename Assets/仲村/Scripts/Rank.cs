using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rank : MonoBehaviour
{
    private float time = PlayTime.rnd;//記録
    [SerializeField] GameObject S;//ランクS
    [SerializeField] GameObject A;//ランクA
    [SerializeField] GameObject B;//ランクB
    [SerializeField] GameObject C;//ランクC

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
        if (time < 60.0f)//timeが60秒未満ならランクS
        {
            S.SetActive(true);
        }
        else if (time <= 75.0f)//timeが75秒以下ならランクA
        {
            A.SetActive(true);
        }
        else if (time <= 80.0f)//timeが80秒以下ならランクB
        {
            B.SetActive(true);
        }
        else//それ以外ならランクC
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