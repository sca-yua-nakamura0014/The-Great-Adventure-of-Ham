using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultMove : MonoBehaviour
{
    [SerializeField] GameObject time;//今回のタイム
    [SerializeField] GameObject rank;//今回のランク
    [SerializeField] GameObject ranking;//現在のランキング
    [SerializeField] GameObject rankname;//ランキングに入れる名前
    public static  int ran;
    private float span = 10.0f;//アニメーションが動く間隔
    private float ElapsedTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Name();//名前のアニメーションを動かす
        Invoke("Timer",0.4f);//0.4秒後に今回のタイムのアニメーションを動かす
        Invoke("Rank",1.0f);//1秒後に今回のランクのアニメーションを動かす
        Invoke("Ranking",1.5f);//1.5秒後にランキングのアニメーションを動かし、効果音を流す

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(ElapsedTime);
        ElapsedTime += Time.deltaTime;
        if (ElapsedTime > span)
        {
            ran = Random.Range(1, 3 + 1);
            //Debug.Log(ran);
            ElapsedTime = 0.0f;
        }
        Titlebgm.bgm = 0;//bgmを０にする
    }

    void Timer()
    {
        time.SetActive(true);
    }
    void Rank()
    {
        rank.SetActive(true);
        
    }
    void Ranking()
    {
        ranking.SetActive(true);
        Invoke("Sound", 0.3f);
        Invoke("Sound", 0.8f);
        Invoke("Sound", 1.3f);
        Invoke("Sound", 1.8f);
        Invoke("Sound", 2.3f); ;
    }
    void Name()
    {
        rankname.SetActive(true);
    }

    void Sound()
    {
        GetComponent<AudioSource>().Play();
    }
}
