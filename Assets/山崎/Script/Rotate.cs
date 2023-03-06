using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //’†S“_‚ğw’è
    [SerializeField]
    float rotateX;
    [SerializeField]
    float rotateY;
    [SerializeField]
    float rotateZ;

    void Update()
    {
        //‰ñ‚·‚¾‚¯‚Ìˆ—
        transform.Rotate(new Vector3(rotateX, rotateY, rotateZ) * Time.deltaTime, Space.World);
    }
}