using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall2 : MonoBehaviour
{
    //[SerializeField]
    protected float waitTime;//目的の所について何秒止まるか

    protected bool stop = false;//判定
    protected bool stop2 = false;

    [SerializeField]
    float moveX;//x方面に動く
    [SerializeField]
    float moveY;//y以下同じ
    [SerializeField]
    float moveZ;//z以下同じ
    [SerializeField]
    float speed;//動くスピード

    float step;
    bool goBack = false;
    Vector3 origin;
    Vector3 destination;



    void Start()
    {
        StartCoroutine(Wait2());
        origin = transform.position;
        destination = new Vector3(origin.x - moveX, origin.y - moveY, origin.z - moveZ);
    }

    void Update()
    {
        if (stop2)
        {
            if (stop)
            {
                return;
            }
            //移動のスピード
            step = speed * Time.deltaTime;

            if (!goBack)
            {
                //ここで移動
                transform.position = Vector3.MoveTowards(transform.position, destination, step);

                if (transform.position == destination)
                {
                    goBack = true;

                    StartCoroutine(Wait());
                }
            }
            else
            {
                //ここで移動
                transform.position = Vector3.MoveTowards(transform.position, origin, step);

                if (transform.position == origin)
                {
                    goBack = false;

                    StartCoroutine(Wait());
                }
            }
        }
    }

    protected IEnumerator Wait()//BOOLの変更
    {
        waitTime = Random.Range(0, 5);
        stop = true;

        yield return new WaitForSeconds(waitTime);

        stop = false;
    }

    protected IEnumerator Wait2()//BOOLの変更
    {
        waitTime = Random.Range(0, 5);
        yield return new WaitForSeconds(waitTime);

        stop2 = true;
    }
}