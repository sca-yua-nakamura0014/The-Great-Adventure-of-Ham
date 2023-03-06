using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public static string one = LoadSave.nameone;//1位の名前
    public static string two = LoadSave.nametwo;//2位の名前
    public static string three = LoadSave.namethree;//3位の名前
    public static string four = LoadSave.namefour;//4位の名前
    public static string five = LoadSave.namefive;//5位の名前
    [SerializeField] private InputField inputName;//名前の入力箇所
    [SerializeField] private Text first;//1位の名前表示箇所
    [SerializeField] private Text second;//2位の名前表示箇所
    [SerializeField] private Text third;//3位の名前表示箇所
    [SerializeField] private Text fourth;//4位の名前表示箇所
    [SerializeField] private Text fifth;//5位の名前表示箇所


    void Start()
    {
        Debug.Log(one);
        Debug.Log(two);
    }

    void Update()
    {
        //何もない場合だれかと表示する
        if(one == ""|| one == "  ")
        {
            one ="だれか";
        }
        if (two == "" || two == "  ")
        {
            two = "だれか";
        }
        if (three == "" || three == "  ")
        {
            three = "だれか";
        }
        if (four == "" || four == "  ")
        {
            four = "だれか";
        }
        if (five == "" || five == "  ")
        {
            five = "だれか";
        }

        first.GetComponent<Text>().text = one;
        second.GetComponent<Text>().text = two;
        third.GetComponent<Text>().text = three;
        fourth.GetComponent<Text>().text = four;
        fifth.GetComponent<Text>().text = five;
     
        
        //int n = inputName.text.Length;

        //新たにランキングに入った値の色を赤にする
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
            if (Ranking.rank == 1)//rankが1の場合1位のところに名前を書く
            {
                one = inputName.text;
                
            }
            else if (Ranking.rank == 2)//rankが2の場合2位のところに名前を書く
            {
                two = inputName.text;
                
            }
            else if (Ranking.rank == 3)//rankが3の場合3位のところに名前を書く
            {
                three = inputName.text;
                
            }
            else if (Ranking.rank == 4)//rankが4の場合4位のところに名前を書く
            {
                four = inputName.text;
                
            }
            else if (Ranking.rank == 5)//rankが5の場合5位のところに名前を書く
            {
                five = inputName.text;
                
            }
        }

        else
        {
            if (Ranking.rank == 1)//rankが1の場合1位のところに名前を書く
            {
                one = "だれか";
                first.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }
            else if (Ranking.rank == 2)//rankが2の場合2位のところに名前を書く
            {
                two = "だれか";
                second.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }
            else if (Ranking.rank == 3)//rankが3の場合3位のところに名前を書く
            {
                three = "だれか";
                third.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }
            else if (Ranking.rank == 4)//rankが4の場合4位のところに名前を書く
            {
                four = "だれか";
                fourth.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }
            else if (Ranking.rank == 5)//rankが5の場合5位のところに名前を書く
            {
                five = "だれか";
                fifth.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }
        }
    }

}