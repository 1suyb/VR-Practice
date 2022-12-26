using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSelect : MonoBehaviour
{
    public GameObject lightselectwindow;
    public void Selected()
    {
        lightselectwindow.SetActive(true);
        lightselectwindow.GetComponent<LightSelectWindow>().streetlight = this.gameObject.GetComponentInChildren<Light>();
    }
}
