using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    private Animator ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = gameObject.GetComponent<Animator>();//Animator�R���|�[�l���g��ݒ�
    }

    // Update is called once per frame
    void Update()
    {
        if(ResultMove.ran == 1)//�l���P�Ȃ�{�[���̃A�j���[�V�����𓮂���
        {
            ball.SetBool("ballBL", true);
            Invoke("Stop", 1.0f);//1�b��������A�j���[�V�������~�߂�
            ResultMove.ran = 0;
        }
        
    }

    void Stop()
    {
        ball.SetBool("ballBL", false);
    }
}
