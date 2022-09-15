using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LightSelectWindow : MonoBehaviour
{
    public byte red;
    public byte green;
    public byte blue;

    public Slider redslider;
    public Slider greenslider;
    public Slider blueslider;

    public Image colorpreview;
    public Light streetlight;

    public void RedSlider()
    {
        red = (byte)redslider.value;
        colorpreview.color = new Color32(red, green, blue, 255);
    }
    public void GreenSlider()
    {
        green = (byte)greenslider.value;
        colorpreview.color = new Color32(red, green, blue, 255);
    }
    public void BlueSlider()
    {
        blue = (byte)blueslider.value;
        colorpreview.color = new Color32(red, green, blue, 255);
    }

    public void Select()
    {
        streetlight.color = new Color32(red, green, blue, 255);
        this.gameObject.SetActive(false);
    }
}
