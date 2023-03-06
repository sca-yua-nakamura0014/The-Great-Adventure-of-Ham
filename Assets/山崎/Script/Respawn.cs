using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
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
        Debug.Log("”»’è");
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("PLAYERŒŸ’m");
            collision.gameObject.transform.position = new Vector3(0, 2, 0);
        }
    }
}
