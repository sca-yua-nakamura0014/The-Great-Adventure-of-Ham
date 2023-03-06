using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    [SerializeField]private float x;
    [SerializeField]private float y;
    [SerializeField]private float z;
    [SerializeField] private float xx;
    [SerializeField] private float yy;
    [SerializeField] private float zz;
    private GameObject obj;
    public static int Fade;
    public static bool Move;
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
        Debug.Log("îªíË");
        if (collision.gameObject.CompareTag("Player"))
        {
            if(Fade==0)
            { 
                Debug.Log("PLAYERåüím");
                obj = collision.gameObject;
                Fade++;
                Move=true;
                Invoke("TLP",1.0f);
            }
            else
            {
                Debug.Log("éËÉåÉ|èÄîıíÜ");
            }
        }
        
    }
    void TLP()
    {
        obj.transform.position = new Vector3(x, y, z);
        obj.transform.Rotate(new Vector3(xx, yy, zz));
        Fade=0;
        Move=false;
    }

}
