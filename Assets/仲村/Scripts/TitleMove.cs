using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMove : MonoBehaviour
{
    [SerializeField] GameObject star;//星
    // Start is called before the first frame update
    void Start()//0.4秒後に星のアニメーションを流す
    {
        Invoke("Star",0.4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Star()
    {
        star.SetActive(true);
    }
}
