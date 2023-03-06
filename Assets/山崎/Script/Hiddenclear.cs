using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hiddenclear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (Player.keycount != 0)
        {
            
            SceneManager.LoadScene("Result");
            Player.keycount = 0;
            Player.itemcount=0;
            Player.Lastitemcount=0;
            
        }
        
        
    }

}