using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingScene : MonoBehaviour
{
    [SerializeField] GameObject first, second, third, fourth, fifth;
    [SerializeField] GameObject firstname, secondname, thirdname, fourthname, fifthname;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Text time1 = first.GetComponent<Text>();
        Text time2 = second.GetComponent<Text>();
        Text time3 = third.GetComponent<Text>();
        Text time4 = fourth.GetComponent<Text>();
        Text time5 = fifth.GetComponent<Text>();

        Text name1 = firstname.GetComponent<Text>();
        Text name2 = secondname.GetComponent<Text>();
        Text name3 = thirdname.GetComponent<Text>();
        Text name4 = fourthname.GetComponent<Text>();
        Text name5 = fifthname.GetComponent<Text>();

        //タイムを分、秒、ミリ秒にする
        time1.text = Mathf.Floor(Ranking.one / 60).ToString("0") + ":" + Mathf.Floor(Ranking.one % 60).ToString("00") + ":" + Mathf.Floor((Ranking.one - Mathf.Floor(Ranking.one)) * 100).ToString("00");
        time2.text = Mathf.Floor(Ranking.two / 60).ToString("0") + ":" + Mathf.Floor(Ranking.two % 60).ToString("00") + ":" + Mathf.Floor((Ranking.two - Mathf.Floor(Ranking.two)) * 100).ToString("00");
        time3.text = Mathf.Floor(Ranking.three / 60).ToString("0") + ":" + Mathf.Floor(Ranking.three % 60).ToString("00") + ":" + Mathf.Floor((Ranking.three - Mathf.Floor(Ranking.three)) * 100).ToString("00");
        time4.text = Mathf.Floor(Ranking.four / 60).ToString("0") + ":" + Mathf.Floor(Ranking.four % 60).ToString("00") + ":" + Mathf.Floor((Ranking.four - Mathf.Floor(Ranking.four)) * 100).ToString("00");
        time5.text = Mathf.Floor(Ranking.five / 60).ToString("0") + ":" + Mathf.Floor(Ranking.five % 60).ToString("00") + ":" + Mathf.Floor((Ranking.five - Mathf.Floor(Ranking.five)) * 100).ToString("00");

        //記録された名前を表示する
        name1.text = Name.one;
        name2.text = Name.two;
        name3.text = Name.three;
        name4.text = Name.four;
        name5.text = Name.five;

        if (Ranking.two == 9999.9f)//最初に表示させる値を0.00.00にする
        {
            time2.text = "0:00:00";
        }

        if (Ranking.three == 9999.9f)
        {
            time3.text = "0:00:00";
        }

        if (Ranking.four == 9999.9f)
        {
            time4.text = "0:00:00";
        }

        if (Ranking.five == 9999.9f)
        {
            time5.text = "0:00:00";
        }

        //何もない場合だれかと表示する
        if (Name.one == ""|| Name.one == "  ")
        {
            name1.text = "だれか";
        }
        if (Name.two == "" || Name.two == "  ")
        {
            name2.text = "だれか";
        }
        if (Name.three == "" || Name.three == "  ")
        {
            name3.text = "だれか";
        }
        if (Name.four == "" || Name.four == "  ")
        {
            name4.text = "だれか";
        }
        if (Name.five == "" || Name.five == "  ")
        {
            name5.text = "だれか";
        }
    }
}
