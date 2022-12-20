using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureChange : MonoBehaviour
{
    public Renderer targetObject;

    private Material defaultMaterial;
    public Material newMaterial;

    private void Start()
    {
        defaultMaterial = targetObject.material;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.U))
        {
            changeTexture();
        }
    }

    public void changeTexture()
    {
        if(targetObject != null)
        {
            if (targetObject.material == newMaterial)
            {
                targetObject.material = defaultMaterial;
            }
            else
            {
                targetObject.material = newMaterial;
            }   
        }
    }
}
