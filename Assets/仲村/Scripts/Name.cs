using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public static string one = LoadSave.nameone;//1�ʂ̖��O
    public static string two = LoadSave.nametwo;//2�ʂ̖��O
    public static string three = LoadSave.namethree;//3�ʂ̖��O
    public static string four = LoadSave.namefour;//4�ʂ̖��O
    public static string five = LoadSave.namefive;//5�ʂ̖��O
    [SerializeField] private InputField inputName;//���O�̓��͉ӏ�
    [SerializeField] private Text first;//1�ʂ̖��O�\���ӏ�
    [SerializeField] private Text second;//2�ʂ̖��O�\���ӏ�
    [SerializeField] private Text third;//3�ʂ̖��O�\���ӏ�
    [SerializeField] private Text fourth;//4�ʂ̖��O�\���ӏ�
    [SerializeField] private Text fifth;//5�ʂ̖��O�\���ӏ�


    void Start()
    {
        Debug.Log(one);
        Debug.Log(two);
    }

    void Update()
    {
        //�����Ȃ��ꍇ���ꂩ�ƕ\������
        if(one == ""|| one == "  ")
        {
            one ="���ꂩ";
        }
        if (two == "" || two == "  ")
        {
            two = "���ꂩ";
        }
        if (three == "" || three == "  ")
        {
            three = "���ꂩ";
        }
        if (four == "" || four == "  ")
        {
            four = "���ꂩ";
        }
        if (five == "" || five == "  ")
        {
            five = "���ꂩ";
        }

        first.GetComponent<Text>().text = one;
        second.GetComponent<Text>().text = two;
        third.GetComponent<Text>().text = three;
        fourth.GetComponent<Text>().text = four;
        fifth.GetComponent<Text>().text = five;
     
        
        //int n = inputName.text.Length;

        //�V���Ƀ����L���O�ɓ������l�̐F��Ԃɂ���
        if (Ranking.rank == 1)
        {
            first.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
        else if (Ranking.rank == 2)
        {
            second.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
        else if (Ranking.rank == 3)
        {
            third.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
        else if (Ranking.rank == 4)
        {
            fourth.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
        else if (Ranking.rank == 5)
        {
            fifth.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }

    }

    public void InputText()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            inputName = GetComponent<InputField>();
            if (Ranking.rank == 1)//rank��1�̏ꍇ1�ʂ̂Ƃ���ɖ��O������
            {
                one = inputName.text;
                
            }
            else if (Ranking.rank == 2)//rank��2�̏ꍇ2�ʂ̂Ƃ���ɖ��O������
            {
                two = inputName.text;
                
            }
            else if (Ranking.rank == 3)//rank��3�̏ꍇ3�ʂ̂Ƃ���ɖ��O������
            {
                three = inputName.text;
                
            }
            else if (Ranking.rank == 4)//rank��4�̏ꍇ4�ʂ̂Ƃ���ɖ��O������
            {
                four = inputName.text;
                
            }
            else if (Ranking.rank == 5)//rank��5�̏ꍇ5�ʂ̂Ƃ���ɖ��O������
            {
                five = inputName.text;
                
            }
        }

        else
        {
            if (Ranking.rank == 1)//rank��1�̏ꍇ1�ʂ̂Ƃ���ɖ��O������
            {
                one = "���ꂩ";
                first.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }
            else if (Ranking.rank == 2)//rank��2�̏ꍇ2�ʂ̂Ƃ���ɖ��O������
            {
                two = "���ꂩ";
                second.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }
            else if (Ranking.rank == 3)//rank��3�̏ꍇ3�ʂ̂Ƃ���ɖ��O������
            {
                three = "���ꂩ";
                third.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }
            else if (Ranking.rank == 4)//rank��4�̏ꍇ4�ʂ̂Ƃ���ɖ��O������
            {
                four = "���ꂩ";
                fourth.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }
            else if (Ranking.rank == 5)//rank��5�̏ꍇ5�ʂ̂Ƃ���ɖ��O������
            {
                five = "���ꂩ";
                fifth.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }
        }
    }

}