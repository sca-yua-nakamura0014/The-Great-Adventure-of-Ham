using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiddenDoor : MonoBehaviour
{
    [SerializeField] Image a;
    [SerializeField] Text textUI;
    bool Check;

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
    void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "Player")
        {
           if(Player.keycount!=0)
            {
                this.gameObject.SetActive(false);
            }
           else
            {
                if(!Check)
                { 
                Debug.Log("ƒJƒM‚ª‚È‚¢‚æ‚¤‚¾");
                a.enabled = true;
                textUI.enabled = true;
                Invoke("aa",2.0f);
                Check=true;
                }
            }
        }
    }

    void aa()
    {
        a.enabled = false;
        textUI.enabled = false;
        Check = false;
    }
}
