using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMove : MonoBehaviour
{
    private Animator cat;
    // Start is called before the first frame update
    void Start()
    {
        cat = gameObject.GetComponent<Animator>();//Animator�R���|�[�l���g��ݒ�
    }

    // Update is called once per frame
    void Update()
    {
        if (ResultMove.ran == 3)//�l��3�Ȃ�L�̃A�j���[�V�����𓮂���
        {
            cat.SetBool("CatBL", true);
            Invoke("Stop", 1.0f);//1�b��������A�j���[�V�������~�߂�
            ResultMove.ran = 0;
        }

    }

    void Stop()
    {
        cat.SetBool("CatBL", false);
    }
}
