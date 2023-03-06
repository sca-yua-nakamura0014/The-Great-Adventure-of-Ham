using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultMove : MonoBehaviour
{
    [SerializeField] GameObject time;//����̃^�C��
    [SerializeField] GameObject rank;//����̃����N
    [SerializeField] GameObject ranking;//���݂̃����L���O
    [SerializeField] GameObject rankname;//�����L���O�ɓ���閼�O
    public static  int ran;
    private float span = 10.0f;//�A�j���[�V�����������Ԋu
    private float ElapsedTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Name();//���O�̃A�j���[�V�����𓮂���
        Invoke("Timer",0.4f);//0.4�b��ɍ���̃^�C���̃A�j���[�V�����𓮂���
        Invoke("Rank",1.0f);//1�b��ɍ���̃����N�̃A�j���[�V�����𓮂���
        Invoke("Ranking",1.5f);//1.5�b��Ƀ����L���O�̃A�j���[�V�����𓮂����A���ʉ��𗬂�

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(ElapsedTime);
        ElapsedTime += Time.deltaTime;
        if (ElapsedTime > span)
        {
            ran = Random.Range(1, 3 + 1);
            //Debug.Log(ran);
            ElapsedTime = 0.0f;
        }
        Titlebgm.bgm = 0;//bgm���O�ɂ���
    }

    void Timer()
    {
        time.SetActive(true);
    }
    void Rank()
    {
        rank.SetActive(true);
        
    }
    void Ranking()
    {
        ranking.SetActive(true);
        Invoke("Sound", 0.3f);
        Invoke("Sound", 0.8f);
        Invoke("Sound", 1.3f);
        Invoke("Sound", 1.8f);
        Invoke("Sound", 2.3f); ;
    }
    void Name()
    {
        rankname.SetActive(true);
    }

    void Sound()
    {
        GetComponent<AudioSource>().Play();
    }
}
