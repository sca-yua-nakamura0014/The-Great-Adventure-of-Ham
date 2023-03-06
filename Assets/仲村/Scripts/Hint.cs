using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hint : MonoBehaviour
{
    private int r;
    [SerializeField] Text door;//隠し扉のヒント
    [SerializeField] Text route;//ルートのヒント
    [SerializeField] Text desk;//机のヒント
    // Start is called before the first frame update
    void Start()
    {
        r = Random.Range(1, 3 + 1);
        //Debug.Log(r);
    }

    // Update is called once per frame
    void Update()
    {
        if(r ==1)//ランダムな値が1なら隠し扉のヒントを表示する
        { 
            route.enabled = false;
            desk.enabled = false;
        }
        else if(r == 2)//ランダムな値が2ならルートのヒントを表示する
        {
            door.enabled = false;
            desk.enabled = false;
        }
        else if (r == 3)//ランダムな値が3なら机のヒントを表示する
        {
            door.enabled = false;
            route.enabled = false;
        }

        if (Input.GetKeyUp(KeyCode.Space))//spaceを押したならsceneを移動する
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
