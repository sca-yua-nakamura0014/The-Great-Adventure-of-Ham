using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleRanking : MonoBehaviour
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
        move.SetBool("TRankBL", true);
    }

    public void Stop()//ボタンから離れたならアニメーションを止める
    {
        move.SetBool("TRankBL", false);

    }

    public void Button()
    {
        SceneManager.LoadScene("Ranking");//ランキング画面へ移動
        //GameStart.musictitle = 1;
    }

    
}
