using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearMove : MonoBehaviour
{
    private Animator bear;
    // Start is called before the first frame update
    void Start()
    {
        bear = gameObject.GetComponent<Animator>();//Animator�R���|�[�l���g��ݒ�
    }

    // Update is called once per frame
    void Update()
    {
        if (ResultMove.ran == 2)//�l��2�Ȃ�F�̃A�j���[�V�����𓮂���
        {
            bear.SetBool("brBL", true);
            Invoke("Stop", 1.0f);//1�b��������A�j���[�V�������~�߂�
            ResultMove.ran = 0;
        }

    }

    void Stop()
    {
        bear.SetBool("brBL", false);
    }
}