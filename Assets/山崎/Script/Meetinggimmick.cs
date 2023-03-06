using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meetinggimmick : MonoBehaviour
{
    [SerializeField] private GameObject obj1;
    [SerializeField] private GameObject obj2;
    int rnd;
    bool GimmickStart;
    // Start is called before the first frame update
    void Start()
    {
        GimmickStart = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GimmickStart = true;
            Rnd();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GimmickStart = false;
        }
    }

    void Rnd()
    {
        if (GimmickStart)
        {
            rnd = Random.Range(1, 3);
            Create();
        }
    }
    void Create()
    {
        if (rnd == 1)
        {
            Instantiate(obj1);
        }
        else
        {
            Instantiate(obj2);
        }
        Invoke("Rnd", 3.0f);
    }


}
