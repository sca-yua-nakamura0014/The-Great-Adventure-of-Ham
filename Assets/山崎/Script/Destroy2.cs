using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy2 : MonoBehaviour
{
    [SerializeField] private float x;
    

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
            if (!confusion.TLPCH)
            {
                confusion.count++;
                confusion.TLPCH = true;
            }
        }
    }


}
