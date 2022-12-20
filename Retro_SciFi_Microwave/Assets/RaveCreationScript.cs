using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaveCreationScript : MonoBehaviour
{
    [SerializeField] private GameObject Rave;
    void Start()
    {
        Rave.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
