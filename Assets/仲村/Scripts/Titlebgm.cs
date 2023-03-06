using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Titlebgm : MonoBehaviour
{
    public bool title = true;
    public static int bgm;
    // Start is called before the first frame update
    void Start()
    {
        GameStart.musictitle = 0;
        bgm++;
        if(bgm !=1)//bgmが1ではないならオブジェクトが重複しないように消す
        {
            Destroy(this.gameObject);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GameStart.musictitle != 0)//musictitleが0ではないときにtitleをfalseにする
        {
            title =false;
        }

        if (title == true)//titleがtrueの時にbgmを流す
        {
            DontDestroyOnLoad(this);
            
        }
        else//titleがfalseなら消す
        {
            Destroy(this.gameObject);
        }

        
        Debug.Log(bgm);

    }
}
