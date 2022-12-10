using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPlates : MonoBehaviour
{
    [Header("Rotation Values")]
    [SerializeField] private float rotationSpeed = 10f;
    [SerializeField] private Rigidbody rotationPlate1;
    [SerializeField] private Rigidbody rotationPlate2;

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
            rotationPlate1.angularVelocity = new Vector3(0f, rotationSpeed, 0f);
            rotationPlate2.angularVelocity = new Vector3(0f, rotationSpeed, 0f);
        }
        else
        {
            rotationPlate1.angularVelocity = new Vector3(0f, 0f, 0f);
            rotationPlate2.angularVelocity = new Vector3(0f, 0f, 0f);
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
