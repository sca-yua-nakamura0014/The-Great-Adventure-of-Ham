using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingRoad : MonoBehaviour
{
    //消したいオブジェクトを設定
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
        //コルーチンのスタート
        StartCoroutine(Flashing1());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Flashing1()
    {
        //二秒まち
        yield return new WaitForSeconds(2.0f);
        //遅らせたい処理
        Rup.SetActive(false);
        Rdown.SetActive(true);
        Lup.SetActive(true);
        Ldown.SetActive(false);
        StartCoroutine(Flashing2());

    }

    IEnumerator Flashing2()
    {
        //上記と同じ
        yield return new WaitForSeconds(2.0f);
        //遅らせたい処理
        Rup.SetActive(true);
        Rdown.SetActive(false);
        Lup.SetActive(false);
        Ldown.SetActive(true);
        StartCoroutine(Flashing1());
    }
}

