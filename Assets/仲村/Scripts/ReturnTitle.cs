using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Ranking.rank = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Title");//ƒ^ƒCƒgƒ‹‰æ–Ê‚ÖˆÚ“®
        GameStart.musictitle = 0;//musictitle‚ð‚O‚É‚·‚é
        
    }
}
