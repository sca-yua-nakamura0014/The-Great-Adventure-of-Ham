using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sisaku : MonoBehaviour
{

    
    public void OnCollisionEnter(Collision collision)
    {
        var rigidbody = GetComponent<Rigidbody>();
        Debug.Log("”½‰ž");
        rigidbody.AddForce(-transform.forward * 5f, ForceMode.VelocityChange);
    }

   
}
