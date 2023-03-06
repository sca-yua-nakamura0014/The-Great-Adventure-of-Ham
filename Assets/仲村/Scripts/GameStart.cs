using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public static int musictitle = 0;
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
        SceneManager.LoadScene("SampleScene");//ƒQ[ƒ€‰æ–Ê‚ÖˆÚ“®
        musictitle++;//musictitle‚É’l‚ğ“ü‚ê‚é
    }
}
