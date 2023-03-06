using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class LoadSave : MonoBehaviour
{
    private float onetime;//ゲームを閉じた時点での1位のタイム
    private float twotime;//ゲームを閉じた時点での2位のタイム
    private float threetime;//ゲームを閉じた時点での3位のタイム
    private float fourtime;//ゲームを閉じた時点での4位のタイム
    private float fivetime;//ゲームを閉じた時点での5位のタイム

    public static float timeone;//ゲームを開いた時点での1位のタイム
    public static float timetwo;//ゲームを開いた時点での2位のタイム
    public static float timethree;//ゲームを開いた時点での3位のタイム
    public static float timefour;//ゲームを開いた時点での4位のタイム
    public static float timefive;//ゲームを開いた時点での5位のタイム


    private string onename;//ゲームを閉じた時点での1位の名前
    private string twoname;//ゲームを閉じた時点での2位の名前
    private string threename;//ゲームを閉じた時点での3位の名前
    private string fourname;//ゲームを閉じた時点での4位の名前
    private string fivename;//ゲームを閉じた時点での5位の名前

    public static string nameone;//ゲームを開いた時点での1位の名前
    public static string nametwo;//ゲームを開いた時点での2位の名前
    public static string namethree;//ゲームを開いた時点での3位の名前
    public static string namefour;//ゲームを開いた時点での4位の名前
    public static string namefive;//ゲームを開いた時点での5位の名前
    // Start is called before the first frame update
    void Start()
    {
        //ゲームが始まったらロードする
        timeone = PlayerPrefs.GetFloat("timekey1");
        timetwo = PlayerPrefs.GetFloat("timekey2");
        timethree = PlayerPrefs.GetFloat("timekey3");
        timefour = PlayerPrefs.GetFloat("timekey4");
        timefive = PlayerPrefs.GetFloat("timekey5");

        nameone = PlayerPrefs.GetString("namekey1");
        nametwo = PlayerPrefs.GetString("namekey2");
        namethree = PlayerPrefs.GetString("namekey3");
        namefour = PlayerPrefs.GetString("namekey4");
        namefive = PlayerPrefs.GetString("namekey5");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    
    
    public void OnApplicationQuit()//ゲームを閉じたらセーブする
    {
        //ランキング画面で記録された時間を入れる
        onetime = Ranking.one;
        twotime = Ranking.two;
        threetime = Ranking.three;
        fourtime = Ranking.four;
        fivetime = Ranking.five;

        //ランキング画面で記録された 名前を入れる
        onename = Name.one;
        twoname = Name.two;
        threename = Name.three;
        fourname = Name.four;
        fivename = Name.five;

        PlayerPrefs.SetFloat("timekey1", onetime);
        PlayerPrefs.SetFloat("timekey2", twotime);
        PlayerPrefs.SetFloat("timekey3", threetime);
        PlayerPrefs.SetFloat("timekey4", fourtime);
        PlayerPrefs.SetFloat("timekey5", fivetime);

        PlayerPrefs.SetString("namekey1",onename);
        PlayerPrefs.SetString("namekey2",twoname);
        PlayerPrefs.SetString("namekey3",threename);
        PlayerPrefs.SetString("namekey4",fourname);
        PlayerPrefs.SetString("namekey5",fivename);

    }
}
