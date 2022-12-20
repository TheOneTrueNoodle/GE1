using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentacleScript : MonoBehaviour
{
    private bool IsActive = true;
    private Vector3 CurrentScale;

    private void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
    }

 /*   private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {                                       Tentacle test part for development outside of vr
            StartCoroutine(Activate());
        }
    } */

    public void ActivateTentacle()
    {
        StartCoroutine(Activate());
    }

    private IEnumerator Activate()
    {
        CurrentScale = transform.localScale;



        if (IsActive == true)
        {
            IsActive = false;
            for (float i = 0; i < 1; i += 0.01f)
            {

                transform.localScale = Vector3.Lerp(CurrentScale, new Vector3(0.8f, 0.8f, 0.8f), i);
                yield return new WaitForSeconds(0.005f);
            }
        }
        else if (IsActive == false)
        {
            IsActive = true;
            for (float i = 0; i < 1; i += 0.01f)
            {
                transform.localScale = Vector3.Lerp(CurrentScale, new Vector3(0.5f, 0.001f, 0.5f), i);
                yield return new WaitForSeconds(0.005f);
            }
        }
        
        yield return null;
    }
}
