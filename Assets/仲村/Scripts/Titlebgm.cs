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
        if(bgm !=1)//bgm��1�ł͂Ȃ��Ȃ�I�u�W�F�N�g���d�����Ȃ��悤�ɏ���
        {
            Destroy(this.gameObject);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GameStart.musictitle != 0)//musictitle��0�ł͂Ȃ��Ƃ���title��false�ɂ���
        {
            title =false;
        }

        if (title == true)//title��true�̎���bgm�𗬂�
        {
            DontDestroyOnLoad(this);
            
        }
        else//title��false�Ȃ����
        {
            Destroy(this.gameObject);
        }

        
        Debug.Log(bgm);

    }
}
