using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //中心点を指定
    [SerializeField]
    float rotateX;
    [SerializeField]
    float rotateY;
    [SerializeField]
    float rotateZ;

    void Update()
    {
        //回すだけの処理
        transform.Rotate(new Vector3(rotateX, rotateY, rotateZ) * Time.deltaTime, Space.World);
    }
}