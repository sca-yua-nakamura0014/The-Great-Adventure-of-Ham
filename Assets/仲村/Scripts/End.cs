using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    [SerializeField] private Sprite close;
    [SerializeField] private Sprite open;
    void Start()
    {
        this.gameObject.GetComponent<Image>().sprite = close;
    }

    public void ButtonExit()//ゲームを終了する
    {
        Application.Quit();
    }

    public void Touch()//ボタンに触れているならドアを開ける画像にする
    {
        this.gameObject.GetComponent<Image>().sprite = open;
    }

    public void Stop()//ボタンから離れたならドアを閉じる画像にする
    {

        this.gameObject.GetComponent<Image>().sprite = close;
    }
}
