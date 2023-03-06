using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public float upForce; //上方向にかける力
    private bool isGround = false;

    public static int itemcount = 0;
    public static int Lastitemcount = 0;
    public static int keycount = 0;

    RaycastHit hit;

    [SerializeField] AudioSource seAudioSource;
    [SerializeField] private Vector3 velocity;  // 移動方向
    [SerializeField] private float moveSpeed; // 移動速度
    [SerializeField] private float rotateSpeed; //回転
    [SerializeField]private Vector3 pos;
    
    /// ///////////////
    public static bool player;
    [SerializeField] private GameObject Pose;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(pos);

        if(!player && Pose.activeSelf==false&&teleport.Move==false)
        { 
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0, -50 * rotateSpeed * Time.deltaTime, 0);
            }

        if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0, 50 * rotateSpeed * Time.deltaTime, 0, 0);
            }

        if (Input.GetKey(KeyCode.W))
            {
                transform.position += transform.forward * moveSpeed * Time.deltaTime;
                if(Physics.Raycast(ray, out hit))
                {
                    float distance = Vector3.Distance(hit.transform.position, transform.position);
                    Debug.Log(distance);

                }
            }

        if (Input.GetKey(KeyCode.S))
            {
               transform.position += transform.forward * moveSpeed * Time.deltaTime * -1;
            }


            if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
            {
                isGround = false;
                rb.AddForce(new Vector3(0, upForce, 0));
                seAudioSource.Play();
            }
        }





        void OnCollisionEnter(Collision collision)
        {
            //衝突した相手にPlayerタグが付いているとき
            if (collision.gameObject.tag == "Player")
            {
                //0.2秒後に消える
                Destroy(gameObject, 0.2f);
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGround = true;
        }
        if (other.gameObject.tag == "item")
        {
            //Debug.Log(other.gameObject);
            if (itemcount <= 8)
            {
                other.gameObject.SetActive(false);
                Debug.Log("増えました");
                itemcount++;
                //Debug.Log(other.gameObject);
            }
            else
            {
                other.gameObject.SetActive(false);
                Debug.Log("これ以上持てない");
            }
        }
        if (other.gameObject.tag == "Key")
        {
            other.gameObject.SetActive(false);
            keycount++;
        }
        if (other.gameObject.tag == "Lastitem")
        {
            if(Lastitemcount==0)
            { 
            other.gameObject.SetActive(false);
            Debug.Log("増えました");
            Lastitemcount++;
            //itemcount = Lastitemcount + itemcount;
            }
            else
            {
                other.gameObject.SetActive(false);
                Debug.Log("これ以上持てない最後のアイテム");
            }
        }
    }

    
}
