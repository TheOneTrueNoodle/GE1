using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Gradient gradient; 
    public float changeInterval = 1f;
    public float lerpSpeed = 1f;
    private Material material;
    private float t = 0f;

    void Start()
    {
        material = GetComponent<Renderer>().material;

        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        while (true)
        {
            material.color = gradient.Evaluate(t);

            t += Time.deltaTime * lerpSpeed;
            if(t > 1f)
            {
                t -= 1f;
            }

            yield return new WaitForSeconds(changeInterval);
        }
    }
}
