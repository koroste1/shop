using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //scene references
    public GameObject ui1;
    public GameObject ui2;
    public GameObject ui3;

    public GameObject UIStop; //предупреждение вначале

    public float myTimer = 2.5f;
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {

    }

    public void Update()
    {
        myTimer -= Time.deltaTime;
        if (myTimer <= 0.0f)
        {
            UIStop.SetActive(false);
        }
    }
    public void ui1but()
    {
        //ui1.activeSelf == false
        ui1.SetActive(false);
        ui2.SetActive(true);
        ui3.SetActive(false);
    }
    public void ui2but()
    {
        //ui1.activeSelf == false
        ui1.SetActive(false);
        ui2.SetActive(false);
        ui3.SetActive(true);
    }
    public void ui3but()
    {
        //ui1.activeSelf == false
        ui1.SetActive(false);
        ui2.SetActive(true);
        ui3.SetActive(false);
    }
    public void homebut()
    {
        //ui1.activeSelf == false
        ui1.SetActive(true);
        ui2.SetActive(false);
        ui3.SetActive(false);
    }
}
