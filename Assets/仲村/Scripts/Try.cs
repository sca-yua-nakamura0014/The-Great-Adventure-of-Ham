using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Try : MonoBehaviour
{
    [SerializeField] GameObject stop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickStartButton()//ボタンを押したらポーズ画面を消す
    {
        stop.SetActive(false);
    }
}
