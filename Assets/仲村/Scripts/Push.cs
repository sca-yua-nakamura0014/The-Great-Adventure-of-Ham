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
            if (Input.GetKeyDown(KeyCode.W))//Wを押したなら色を変える
            {
                W.GetComponent<Image>().color = new Color32(219, 211, 199, 255);
            }
            else if (Input.GetKeyUp(KeyCode.W))//Wを離したら色を戻す
            {
                W.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }

            if (Input.GetKeyDown(KeyCode.A))//Aを押したなら色を変える
            {
                A.GetComponent<Image>().color = new Color32(219, 211, 199, 255);
            }
            else if (Input.GetKeyUp(KeyCode.A))//Aを離したら色を戻す
            {
                A.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }

            if (Input.GetKeyDown(KeyCode.S))//Sを押したなら色を変える
            {
                S.GetComponent<Image>().color = new Color32(219, 211, 199, 255);
            }
            else if (Input.GetKeyUp(KeyCode.S))//Sを離したら色を戻す
            {
                S.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }

            if (Input.GetKeyDown(KeyCode.D))//Dを押したなら色を変える
            {
                D.GetComponent<Image>().color = new Color32(219, 211, 199, 255);
            }
            else if (Input.GetKeyUp(KeyCode.D))//Dを離したら色を戻す
            {
                D.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }

            if (Input.GetKeyDown(KeyCode.Space))//Spaceを押したなら色を変える
            {
                Space.GetComponent<Image>().color = new Color32(219, 211, 199, 255);
            }
            else if (Input.GetKeyUp(KeyCode.Space))//Spaceを離したら色を戻す
            {
                Space.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }

            if (Input.GetKeyDown(KeyCode.Escape))//Escapeを押したなら色を変える
            {
                Esc.GetComponent<Image>().color = new Color32(219, 211, 199, 255);
            }
            else if (Input.GetKeyUp(KeyCode.Escape))//Escapeを離したら色を戻す
            {
                Esc.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }

            if (Input.GetMouseButtonDown(0))//クリックしたなら色を変える
            {
                Cl.GetComponent<Image>().color = new Color32(219, 211, 199, 255);
            }
            else if (Input.GetMouseButtonUp(0))//クリックしたなら色を戻す
            {
                Cl.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }

        }
    }
}
