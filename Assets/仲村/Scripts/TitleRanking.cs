using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleRanking : MonoBehaviour
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
        move.SetBool("TRankBL", true);
    }

    public void Stop()//�{�^�����痣�ꂽ�Ȃ�A�j���[�V�������~�߂�
    {
        move.SetBool("TRankBL", false);

    }

    public void Button()
    {
        SceneManager.LoadScene("Ranking");//�����L���O��ʂֈړ�
        //GameStart.musictitle = 1;
    }

    
}
