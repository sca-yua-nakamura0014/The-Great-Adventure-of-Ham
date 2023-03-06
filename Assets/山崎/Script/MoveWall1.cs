using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall1 : MonoBehaviour
{
    [SerializeField]
    protected float waitTime;//�ړI�̏��ɂ��ĉ��b�~�܂邩

    protected bool stop = false;//����


    [SerializeField]
    float moveX;//x���ʂɓ���
    [SerializeField]
    float moveY;//y�ȉ�����
    [SerializeField]
    float moveZ;//z�ȉ�����
    [SerializeField]
    float speed;//�����X�s�[�h

    float step;
    bool goBack = false;
    Vector3 origin;
    Vector3 destination;

    void Start()
    {
        origin = transform.position;
        destination = new Vector3(origin.x - moveX, origin.y - moveY, origin.z - moveZ);
    }

    void Update()
    {
        if (stop)
        {
            return;
        }
        //�ړ��̃X�s�[�h
        step = speed * Time.deltaTime;

        if (!goBack)
        {
            //�����ňړ�
            transform.position = Vector3.MoveTowards(transform.position, destination, step);

            if (transform.position == destination)
            {
                goBack = true;

                StartCoroutine(Wait());
            }
        }
        else
        {
            //�����ňړ�
            transform.position = Vector3.MoveTowards(transform.position, origin, step);

            if (transform.position == origin)
            {
                goBack = false;

                StartCoroutine(Wait());
            }
        }
    }

    protected IEnumerator Wait()//BOOL�̕ύX
    {
        stop = true;

        yield return new WaitForSeconds(waitTime);

        stop = false;
    }
}