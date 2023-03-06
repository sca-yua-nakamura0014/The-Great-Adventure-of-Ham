using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Push : MonoBehaviour
{
    [SerializeField] GameObject W;
    [SerializeField] GameObject A;
    [SerializeField] GameObject S;
    [SerializeField] GameObject D;
    [SerializeField] GameObject Space;
    [SerializeField] GameObject Esc;
    [SerializeField] GameObject Cl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject == true)
        {
            if (Input.GetKeyDown(KeyCode.W))//W���������Ȃ�F��ς���
            {
                W.GetComponent<Image>().color = new Color32(219, 211, 199, 255);
            }
            else if (Input.GetKeyUp(KeyCode.W))//W�𗣂�����F��߂�
            {
                W.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }

            if (Input.GetKeyDown(KeyCode.A))//A���������Ȃ�F��ς���
            {
                A.GetComponent<Image>().color = new Color32(219, 211, 199, 255);
            }
            else if (Input.GetKeyUp(KeyCode.A))//A�𗣂�����F��߂�
            {
                A.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }

            if (Input.GetKeyDown(KeyCode.S))//S���������Ȃ�F��ς���
            {
                S.GetComponent<Image>().color = new Color32(219, 211, 199, 255);
            }
            else if (Input.GetKeyUp(KeyCode.S))//S�𗣂�����F��߂�
            {
                S.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }

            if (Input.GetKeyDown(KeyCode.D))//D���������Ȃ�F��ς���
            {
                D.GetComponent<Image>().color = new Color32(219, 211, 199, 255);
            }
            else if (Input.GetKeyUp(KeyCode.D))//D�𗣂�����F��߂�
            {
                D.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }

            if (Input.GetKeyDown(KeyCode.Space))//Space���������Ȃ�F��ς���
            {
                Space.GetComponent<Image>().color = new Color32(219, 211, 199, 255);
            }
            else if (Input.GetKeyUp(KeyCode.Space))//Space�𗣂�����F��߂�
            {
                Space.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }

            if (Input.GetKeyDown(KeyCode.Escape))//Escape���������Ȃ�F��ς���
            {
                Esc.GetComponent<Image>().color = new Color32(219, 211, 199, 255);
            }
            else if (Input.GetKeyUp(KeyCode.Escape))//Escape�𗣂�����F��߂�
            {
                Esc.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }

            if (Input.GetMouseButtonDown(0))//�N���b�N�����Ȃ�F��ς���
            {
                Cl.GetComponent<Image>().color = new Color32(219, 211, 199, 255);
            }
            else if (Input.GetMouseButtonUp(0))//�N���b�N�����Ȃ�F��߂�
            {
                Cl.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }

        }
    }
}
