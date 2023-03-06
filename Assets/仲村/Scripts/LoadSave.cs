using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class LoadSave : MonoBehaviour
{
    private float onetime;//�Q�[����������_�ł�1�ʂ̃^�C��
    private float twotime;//�Q�[����������_�ł�2�ʂ̃^�C��
    private float threetime;//�Q�[����������_�ł�3�ʂ̃^�C��
    private float fourtime;//�Q�[����������_�ł�4�ʂ̃^�C��
    private float fivetime;//�Q�[����������_�ł�5�ʂ̃^�C��

    public static float timeone;//�Q�[�����J�������_�ł�1�ʂ̃^�C��
    public static float timetwo;//�Q�[�����J�������_�ł�2�ʂ̃^�C��
    public static float timethree;//�Q�[�����J�������_�ł�3�ʂ̃^�C��
    public static float timefour;//�Q�[�����J�������_�ł�4�ʂ̃^�C��
    public static float timefive;//�Q�[�����J�������_�ł�5�ʂ̃^�C��


    private string onename;//�Q�[����������_�ł�1�ʂ̖��O
    private string twoname;//�Q�[����������_�ł�2�ʂ̖��O
    private string threename;//�Q�[����������_�ł�3�ʂ̖��O
    private string fourname;//�Q�[����������_�ł�4�ʂ̖��O
    private string fivename;//�Q�[����������_�ł�5�ʂ̖��O

    public static string nameone;//�Q�[�����J�������_�ł�1�ʂ̖��O
    public static string nametwo;//�Q�[�����J�������_�ł�2�ʂ̖��O
    public static string namethree;//�Q�[�����J�������_�ł�3�ʂ̖��O
    public static string namefour;//�Q�[�����J�������_�ł�4�ʂ̖��O
    public static string namefive;//�Q�[�����J�������_�ł�5�ʂ̖��O
    // Start is called before the first frame update
    void Start()
    {
        //�Q�[�����n�܂����烍�[�h����
        timeone = PlayerPrefs.GetFloat("timekey1");
        timetwo = PlayerPrefs.GetFloat("timekey2");
        timethree = PlayerPrefs.GetFloat("timekey3");
        timefour = PlayerPrefs.GetFloat("timekey4");
        timefive = PlayerPrefs.GetFloat("timekey5");

        nameone = PlayerPrefs.GetString("namekey1");
        nametwo = PlayerPrefs.GetString("namekey2");
        namethree = PlayerPrefs.GetString("namekey3");
        namefour = PlayerPrefs.GetString("namekey4");
        namefive = PlayerPrefs.GetString("namekey5");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    
    
    public void OnApplicationQuit()//�Q�[���������Z�[�u����
    {
        //�����L���O��ʂŋL�^���ꂽ���Ԃ�����
        onetime = Ranking.one;
        twotime = Ranking.two;
        threetime = Ranking.three;
        fourtime = Ranking.four;
        fivetime = Ranking.five;

        //�����L���O��ʂŋL�^���ꂽ ���O������
        onename = Name.one;
        twoname = Name.two;
        threename = Name.three;
        fourname = Name.four;
        fivename = Name.five;

        PlayerPrefs.SetFloat("timekey1", onetime);
        PlayerPrefs.SetFloat("timekey2", twotime);
        PlayerPrefs.SetFloat("timekey3", threetime);
        PlayerPrefs.SetFloat("timekey4", fourtime);
        PlayerPrefs.SetFloat("timekey5", fivetime);

        PlayerPrefs.SetString("namekey1",onename);
        PlayerPrefs.SetString("namekey2",twoname);
        PlayerPrefs.SetString("namekey3",threename);
        PlayerPrefs.SetString("namekey4",fourname);
        PlayerPrefs.SetString("namekey5",fivename);

    }
}
