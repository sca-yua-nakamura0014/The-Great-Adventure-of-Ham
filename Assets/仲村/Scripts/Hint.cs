using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hint : MonoBehaviour
{
    private int r;
    [SerializeField] Text door;//�B�����̃q���g
    [SerializeField] Text route;//���[�g�̃q���g
    [SerializeField] Text desk;//���̃q���g
    // Start is called before the first frame update
    void Start()
    {
        r = Random.Range(1, 3 + 1);
        //Debug.Log(r);
    }

    // Update is called once per frame
    void Update()
    {
        if(r ==1)//�����_���Ȓl��1�Ȃ�B�����̃q���g��\������
        { 
            route.enabled = false;
            desk.enabled = false;
        }
        else if(r == 2)//�����_���Ȓl��2�Ȃ烋�[�g�̃q���g��\������
        {
            door.enabled = false;
            desk.enabled = false;
        }
        else if (r == 3)//�����_���Ȓl��3�Ȃ���̃q���g��\������
        {
            door.enabled = false;
            route.enabled = false;
        }

        if (Input.GetKeyUp(KeyCode.Space))//space���������Ȃ�scene���ړ�����
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
