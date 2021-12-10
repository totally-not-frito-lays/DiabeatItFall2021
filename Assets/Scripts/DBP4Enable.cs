using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DBP4Enable : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    public Transform canvas;
    public GameObject nextButton;
    public GameObject grayNextButton;

    private bool clicked1 = false;
    private bool clicked2 = false;
    private bool clicked3 = false;

    private GameObject myNext;

    // Start is called before the first frame update
    void Start()
    {
      button1.onClick.AddListener(But1);
      button2.onClick.AddListener(But2);
      button3.onClick.AddListener(But3);
      myNext = Instantiate(nextButton) as GameObject;
    }


    void But1() {
      clicked1 = true;

        if(clicked1 && clicked2 && clicked3) {
          Instantiate(nextButton);
          myNext.transform.parent = canvas;
          myNext.transform.position = new Vector3(3.633f, -2.722f, 0);
        }
    }

    void But2() {
      clicked2 = true;

        if(clicked1 && clicked2 && clicked3) {
          Instantiate(nextButton);
          myNext.transform.parent = canvas;
          myNext.transform.position = new Vector3(3.633f, -2.722f, 0);
        }
    }

    void But3() {
      clicked3 = true;

        if(clicked1 && clicked2 && clicked3) {
          Instantiate(nextButton);
          myNext.transform.parent = canvas;
          myNext.transform.position = new Vector3(3.633f, -2.722f, 0);
        }
    }
}
