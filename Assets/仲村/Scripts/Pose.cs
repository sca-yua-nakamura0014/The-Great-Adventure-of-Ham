using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pose : MonoBehaviour
{
    [SerializeField] GameObject stop;
    // Start is called before the first frame update
    void Start()
    {
        stop.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))//�G�X�P�[�v���������Ȃ�|�[�Y��ʂ�\������
        {
            stop.SetActive(true);
        }
    }
}
