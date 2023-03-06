using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C : MonoBehaviour
{
    private Vector3 angle;

    private Vector3 primary_angle;

    private GameObject playerObject;

    [SerializeField] private GameObject Pose;

    void Start()
    {
        angle = this.gameObject.transform.localEulerAngles;

        primary_angle = this.gameObject.transform.localEulerAngles;

        playerObject = GameObject.Find("hamÅQ");
    }


    void Update()
    {
        if(Pose.activeSelf==false)
        { 
        angle.y += Input.GetAxis("Mouse X");

        if (angle.y <= primary_angle.y - 45f)
        {
            angle.y = primary_angle.y - 45f;
        }
        if (angle.y >= primary_angle.y + 45f)
        {
            angle.y = primary_angle.y + 45f;
        }

        angle.x -= Input.GetAxis("Mouse Y");

        if (angle.x <= primary_angle.x - 20f)
        {
            angle.x = primary_angle.x - 20f;
        }
        if (angle.x >= primary_angle.x + 20f)
        {
            angle.x = primary_angle.x + 20f;
        }

        this.gameObject.transform.localEulerAngles = angle;
        }
    }
}
