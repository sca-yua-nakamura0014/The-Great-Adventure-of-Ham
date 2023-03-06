using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingRoad : MonoBehaviour
{
    //���������I�u�W�F�N�g��ݒ�
    [SerializeField] GameObject Rup;
    [SerializeField] GameObject Rdown;
    [SerializeField] GameObject Lup;
    [SerializeField] GameObject Ldown;
    // Start is called before the first frame update
    void Start()
    {

        Rup.SetActive(false);
        Rdown.SetActive(true);
        Lup.SetActive(true);
        Ldown.SetActive(false);
        //�R���[�`���̃X�^�[�g
        StartCoroutine(Flashing1());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Flashing1()
    {
        //��b�܂�
        yield return new WaitForSeconds(2.0f);
        //�x�点��������
        Rup.SetActive(false);
        Rdown.SetActive(true);
        Lup.SetActive(true);
        Ldown.SetActive(false);
        StartCoroutine(Flashing2());

    }

    IEnumerator Flashing2()
    {
        //��L�Ɠ���
        yield return new WaitForSeconds(2.0f);
        //�x�点��������
        Rup.SetActive(true);
        Rdown.SetActive(false);
        Lup.SetActive(false);
        Ldown.SetActive(true);
        StartCoroutine(Flashing1());
    }
}

