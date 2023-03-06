using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HintScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickResultButton()
    {
        SceneManager.LoadScene("Hint");//ƒqƒ“ƒg‰æ–Ê‚ÖˆÚ“®
        Player.keycount = 0;
        Player.itemcount = 0;
        Player.Lastitemcount = 0;
        teleport.Move = false;
        teleport.Fade = 0;
    }
}
