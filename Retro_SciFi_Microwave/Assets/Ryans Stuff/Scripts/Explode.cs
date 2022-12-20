using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public List<GameObject> pieces;

    private bool Exploded;
    private Rigidbody rb;

    [SerializeField] private ParticleSystem particleSys;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void explode(float force, float radius, float upward)
    {
        if (Exploded) { return; }

        particleSys.Play();

        foreach(GameObject obj in pieces)
        {
            Rigidbody newrb = obj.GetComponent<Rigidbody>();
            newrb.isKinematic = false;
            Vector3 direction = Random.insideUnitSphere;
            newrb.AddForce(direction.normalized * force);

            obj.GetComponent<Collider>().enabled = true;
        }

        rb.AddExplosionForce(force, transform.position, radius, upward);
        Exploded = true;
    }
}
