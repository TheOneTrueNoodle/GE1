using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NewInteractionScript : MonoBehaviour
{
    [SerializeField] private UnityEvent UEvent;
    //[SerializeField] private MonoBehaviour Script;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Activated();
        }
    }

    public void Activated()
    {
        UEvent.Invoke();
    }
}
