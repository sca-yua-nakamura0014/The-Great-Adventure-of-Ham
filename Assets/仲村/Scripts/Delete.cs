using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(2))//���N���b�N��������PlayerPrefs�̃f�[�^���폜����
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
