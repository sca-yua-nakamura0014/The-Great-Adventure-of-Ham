using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    [SerializeField] private Sprite close;
    [SerializeField] private Sprite open;
    void Start()
    {
        this.gameObject.GetComponent<Image>().sprite = close;
    }

    public void ButtonExit()//�Q�[�����I������
    {
        Application.Quit();
    }

    public void Touch()//�{�^���ɐG��Ă���Ȃ�h�A���J����摜�ɂ���
    {
        this.gameObject.GetComponent<Image>().sprite = open;
    }

    public void Stop()//�{�^�����痣�ꂽ�Ȃ�h�A�����摜�ɂ���
    {

        this.gameObject.GetComponent<Image>().sprite = close;
    }
}
