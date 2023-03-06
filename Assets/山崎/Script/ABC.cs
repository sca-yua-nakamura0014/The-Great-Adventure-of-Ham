using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("A"))
        { 
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(-transform.forward * 300f, ForceMode.Acceleration);
        }
    }
}
