using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))//�G���^�[����������^�C�g���֖߂�
        {
            SceneManager.LoadScene("Title");
            Titlebgm.bgm = 0;
        }
    }
}
