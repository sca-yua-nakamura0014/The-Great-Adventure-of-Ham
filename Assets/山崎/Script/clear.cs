using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class clear : MonoBehaviour
{
    [SerializeField] Image a;
    [SerializeField] Text textUI;
    bool Check;
    public static bool Sound;
    // Start is called before the first frame update
    void Start()
    {
        a.enabled = false;
        textUI.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        
        if (Player.itemcount==9&&Player.Lastitemcount==1)
        {
            Player.itemcount = 0;
            Player.Lastitemcount = 0;
            Sound = true;
            Invoke("cleara",2.0f);
        }
        else
        {
            Debug.Log("‘«‚è‚È‚¢");
            
            if(!Check)
            { 
           
                a.enabled = true;
                textUI.enabled = true;
                Invoke("aa", 2.0f);
                Check = true;
            }
        }
    }
    void aa()
    {
        a.enabled = false;
        textUI.enabled = false;
        Check=false;
        Sound=false;
    }
    void cleara()
    {
        SceneManager.LoadScene("Result");       
    }
}
