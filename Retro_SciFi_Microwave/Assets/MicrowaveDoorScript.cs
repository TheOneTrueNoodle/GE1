using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrowaveDoorScript : MonoBehaviour
{
    private bool IsOpen = false;
    private Vector3 currentpos;
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            StartCoroutine(Activate());
        }
    } 

    public IEnumerator Activate()
    {
        currentpos = transform.position;
        if (IsOpen == false)
        {
            IsOpen = true;
            for (float i = 0; i < 1; i += 0.01f)
            {
             transform.position=   Vector3.Lerp(currentpos, new Vector3(2, 0, 0), i);
                  yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            IsOpen = false;
            for (float i = 0; i < 1; i += 0.01f)
            {
                transform.position = Vector3.Lerp(currentpos, new Vector3(0, 0, 0), i);
               yield return new WaitForSeconds(0.01f);
            }
        }

        yield return null;
    }
}
