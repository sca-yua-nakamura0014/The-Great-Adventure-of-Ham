using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBgm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("BGM",4.5f);//4.5秒後にBGMを流す
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BGM()
    {
        GetComponent<AudioSource>().Play();
    }
}
