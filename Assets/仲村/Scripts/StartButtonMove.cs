using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonMove : MonoBehaviour
{
    private Animator move;
    // Start is called before the first frame update
    void Start()
    {
        move = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Touch()//�{�^���ɐG��Ă���Ȃ�A�j���[�V�����𓮂���
    {
        move.SetBool("StartButtonBL", true);
    }

    public void Stop()//�{�^�����痣�ꂽ�Ȃ�A�j���[�V�������~�߂�
    {
        move.SetBool("StartButtonBL", false);

    }
}
