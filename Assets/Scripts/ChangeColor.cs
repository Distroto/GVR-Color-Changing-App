using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChangeColor : MonoBehaviour
{
    public void ChangeColorEnter()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    public void ChangeColorExit()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
