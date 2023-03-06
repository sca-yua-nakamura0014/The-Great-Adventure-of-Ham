using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    [SerializeField] private float x;
    [SerializeField] private GameObject obj;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(DelayMethod), x);
    }
    void DelayMethod()
    {
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(!Sleep.TLPCH)
            { 
                Sleep.count++;
                Sleep.TLPCH=true;
            }
        }
    }
    

}
