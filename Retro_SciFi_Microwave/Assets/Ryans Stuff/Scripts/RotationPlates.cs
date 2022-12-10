using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPlates : MonoBehaviour
{
    [Header("Rotation Values")]
    [SerializeField] private float rotationSpeed = 10f;
    [SerializeField] private float blenderSpeed = 10f;
    private float currentSpeed;
    [SerializeField] private Rigidbody rotationPlate1;
    [SerializeField] private Rigidbody rotationPlate2;

    private bool rotating = false;

    private void Start()
    {
        currentSpeed = rotationSpeed;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            toggleRotation();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            toggleBlenderMode();
        }
    }

    private void FixedUpdate()
    {
        if (rotating)
        {
            rotationPlate1.angularVelocity = new Vector3(0f, currentSpeed, 0f);
            rotationPlate2.angularVelocity = new Vector3(0f, currentSpeed, 0f);
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

    public void toggleBlenderMode()
    {
        if(currentSpeed != blenderSpeed)
        {
            currentSpeed = blenderSpeed;
        }
        else
        {
            currentSpeed = rotationSpeed;
        }
    }
}
