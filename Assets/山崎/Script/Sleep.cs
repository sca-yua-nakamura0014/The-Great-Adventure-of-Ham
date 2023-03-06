using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sleep : MonoBehaviour
{
    [SerializeField] Text textUI;
    [SerializeField] Image a;
    public string[] texts;
    int textNumber;
    string displayText;
    int textCharNumber;
    public static int count=0;
    public static int fade=0;
    int textcount;
    [SerializeField]private GameObject obj;
    public static bool TLPCH;
    

    void Start()
    {
        a.enabled = false;
        textUI.enabled = false;
        //text();
    }
    void Update()
    {
        //Debug.Log(count);
        if(count!=0)
        { 
            text();
            
        }
    }
    void text()
    {
        Player.player=true;
        
        count=0;
        a.enabled = true;
        textUI.enabled = true;
        if (textCharNumber != texts[textNumber].Length) //’Ç‰Á
        {//’Ç‰Á
            displayText = displayText + texts[textNumber][textCharNumber];//’Ç‰Á
            textCharNumber = textCharNumber + 1;//’Ç‰Á
        }//’Ç‰Á
        else//’Ç‰Á
        {//’Ç‰Á
            displayText = "";//’Ç‰Á
            textCharNumber = 0;//’Ç‰Á
        }//’Ç‰Á

        this.GetComponent<Text>().text = displayText;
        if (textNumber != texts.Length - 1)
        {

        }
        if(textCharNumber == texts[textNumber].Length)
        {
            
            Invoke("text2", 0.5f);
            Invoke("TLP", 1.5f);

        }
        else
        { 
            Invoke("text",0.5f);
        }
    }
    void text2()
    {
        
        fade++;
        a.enabled = false;
        textUI.enabled = false;
        
    }
    void TLP()
    {
        obj.transform.position = new Vector3(-4.0f, -0.4f, 1.0f);
        TLPCH=false;
        Player.player = false;
        fade=0;
    }


}
