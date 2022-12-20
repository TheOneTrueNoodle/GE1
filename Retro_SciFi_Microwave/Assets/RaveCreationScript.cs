using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaveCreationScript : MonoBehaviour
{
    [SerializeField] private GameObject Rave;
    [SerializeField] private GameObject Music;
    private bool raveactive = false;
    void Start()
    {
        Rave.SetActive(false);
    }
    

    public void RaveActive()
    {
        if(raveactive == false)
        {
            raveactive = true;
            Rave.SetActive(true);
            GameObject DreamMask = Instantiate(Music, transform.position, Quaternion.identity);
            // this is creating a new music every time the rave happens- this is on purpose
            // as it is a variable i am able to call the destroy(DreamMask) function in the rave stopping 
            // part of the script, however i do not want to do that.
            return;
        }
        if(raveactive == true)
        {
            raveactive = false;
            Rave.SetActive(false);
            return;
        }
    }
}
