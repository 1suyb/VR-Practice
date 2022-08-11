using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Material Active;
    public Material deActive;
    public void Activated()
    {
        this.GetComponent<MeshRenderer>().material = Active;
    }

    public void Deact()
    {
            this.GetComponent<MeshRenderer>().material = deActive;
    }
}
