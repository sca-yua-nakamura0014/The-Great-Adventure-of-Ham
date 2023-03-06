using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pose : MonoBehaviour
{
    [SerializeField] GameObject stop;
    // Start is called before the first frame update
    void Start()
    {
        stop.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))//エスケープを押したならポーズ画面を表示する
        {
            stop.SetActive(true);
        }
    }
}
