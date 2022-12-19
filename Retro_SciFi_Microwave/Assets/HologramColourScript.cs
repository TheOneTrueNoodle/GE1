using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HologramColourScript : MonoBehaviour
{
    [SerializeField] private Material mat;
   
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.K))
        {
            mat.SetColor("_Colour", Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
        }
    }
}
