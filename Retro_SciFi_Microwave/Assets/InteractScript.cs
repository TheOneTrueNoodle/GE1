using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractScript : MonoBehaviour
{
    
    [SerializeField] private MonoBehaviour Script;
    public void Activated()
    {

        Script.StartCoroutine("Activate"); 

    }
}
