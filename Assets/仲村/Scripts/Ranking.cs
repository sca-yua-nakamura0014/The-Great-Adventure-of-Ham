using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Ranking : MonoBehaviour
{
    // Start is called before the first frame update
    public static float one = LoadSave.timeone;//1位の初期のタイム
    public static float two = LoadSave.timetwo;//2位の初期のタイム
    public static float three = LoadSave.timethree;//3位の初期のタイム
    public static float four = LoadSave.timefour;//4位の初期のタイム
    public static float five = LoadSave.timefive;//5位の初期のタイム
    public static int rank = 100;//今回の順位
    private float time = PlayTime.rnd;//記録
    [SerializeField] GameObject first, second, third, fourth, fifth;
    [SerializeField] private GameObject inputName;//名前の入力箇所

    void Start()
    {
        //Debug.Log(LoadSave.timeone);
        //Debug.Log(one);
        
    }

    // Update is called once per frame
    void Update()
    {   //最初のタイムを9999.9秒にする
        if (two == 0)
        {
            two = 9999.9f;
        }
        if (three == 0)
        {
            three = 9999.9f;
        }
        if (four == 0)
        {
            four = 9999.9f;
        }
        if (five == 0)
        {
            five = 9999.9f;
        }

        Text time1 = first.GetComponent<Text>();
        Text time2 = second.GetComponent<Text>();
        Text time3 = third.GetComponent<Text>();
        Text time4 = fourth.GetComponent<Text>();
        Text time5 = fifth.GetComponent<Text>();

        if (time < one || one == 0.0f)//記録がoneより小さかったら表示
        {
            rank = 1;
            five = four;
            four = three;
            three = two;
            two = one;
            one = time;
            //Debug.Log(two);

            Name.five = Name.four;
            Name.four = Name.three;
            Name.three = Name.two;
            Name.two = Name.one;
            Name.one = "  ";
            time1.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);

        }
        else if (time < two && time != one)//記録がtwoより小さく他の記録と等しくないならと等しくないなら表示
        {
            rank = 2;
            five = four;
            four = three;
            three = two;
            two = time;

            Name.five = Name.four;
            Name.four = Name.three;
            Name.three = Name.two;
            Name.two = "  ";
            time2.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
        else if (time < three && time != one && time != two)//記録がthreより小さく他の記録と等しくないならと等しくないなら表示
        {
            rank = 3;
            five = four;
            four = three;
            three = time;

            Name.five = Name.four;
            Name.four = Name.three;
            Name.three = "  ";
            time3.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }

        else if (time < four && time != one && time != two && time != three)//記録がfourより小さく他の記録と等しくないならと等しくないなら表示
        {
            rank = 4;
            five = four;
            four = time;

            Name.five = Name.four;
            Name.four = "  ";
            time4.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
        else if (time < five && time != one && time != two && time != three && time != four)//記録がfiveより小さく他の記録と等しくないならと等しくないなら表示
        {
            rank = 5;
            five = time;
            Name.five = "  ";
            time5.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }

        if (rank == 100)//rankが100なら入力できないようにする
        {
            inputName.SetActive(false);
        }

        //タイムを分、秒、ミリ秒にする
        time1.text = Mathf.Floor(one/60).ToString("0") + ":" + Mathf.Floor(one%60).ToString("00") + ":" + Mathf.Floor((one - Mathf.Floor(one)) * 100).ToString("00");
        time2.text = Mathf.Floor(two / 60).ToString("0") + ":" + Mathf.Floor(two % 60).ToString("00") + ":" + Mathf.Floor((two - Mathf.Floor(two)) * 100).ToString("00");
        time3.text = Mathf.Floor(three / 60).ToString("0") + ":" + Mathf.Floor(three % 60).ToString("00") + ":" + Mathf.Floor((three - Mathf.Floor(three)) * 100).ToString("00");
        time4.text = Mathf.Floor(four / 60).ToString("0") + ":" + Mathf.Floor(four % 60).ToString("00") + ":" + Mathf.Floor((four - Mathf.Floor(four)) * 100).ToString("00");
        time5.text = Mathf.Floor(five/ 60).ToString("0") + ":" + Mathf.Floor(five % 60).ToString("00") + ":" + Mathf.Floor((five - Mathf.Floor(five)) * 100).ToString("00");
        //最初に表示させる値を0.00.00にする
        if (two == 9999.9f)
        {
            time2.text = "0:00:00";
        }

        if (three == 9999.9f)
        {
            time3.text = "0:00:00";
        }

        if (four == 9999.9f)
        {
            time4.text = "0:00:00";
        }

        if (five == 9999.9f)
        {
            time5.text = "0:00:00";
        }

    }

}
