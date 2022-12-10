using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPlates : MonoBehaviour
{
    [Header("Rotation Values")]
    [SerializeField] private float rotationSpeed = 10f;
    [SerializeField] private GameObject rotationPlate1;
    [SerializeField] private GameObject rotationPlate2;

    private bool rotating = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            toggleRotation();
        }
    }

    private void FixedUpdate()
    {
        if (rotating)
        {
            rotationPlate1.transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
            rotationPlate2.transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        }
    }

    public void toggleRotation()
    {
        if(rotating)
        {
            rotating = false;
        }
        else
        {
            rotating = true;
        }
    }
}
