using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    [Header("List of Spawnable Foods")]
    [SerializeField] private List<GameObject> FoodPrefabs;
    [Header("List of Spawned Foods")]
    public List<GameObject> SpawnedFood;
    [HideInInspector] public List<GameObject> EjectableFood;

    [Header("Food Spawning Values")]
    [SerializeField] private Transform spawnTransform;

    private int NextFood;

    [Header("Food Ejection Variables")]
    public Transform ejectTransform;
    public GameObject forceSource;
    public float minForce = 10f;
    public float maxForce = 100f;

    private void Start()
    {
        if(FoodPrefabs != null)
        {
            ShuffleFoodOrder();
            NextFood = Random.Range(0, FoodPrefabs.Count - 1);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            SpawnFood();
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            FoodEject();
        }
    }

    public void SpawnFood()
    {
        if(FoodPrefabs == null) { return; }

        GameObject newFood = Instantiate(FoodPrefabs[NextFood]);
        newFood.transform.position = spawnTransform.position;
        SpawnedFood.Add(newFood);
        EjectableFood.Add(newFood);

        NextFood++;
        if (NextFood >= FoodPrefabs.Count) { NextFood = 0; }
    }

    private void ShuffleFoodOrder()
    {
        for(int i = 0; i < FoodPrefabs.Count; i++)
        {
            GameObject temp = FoodPrefabs[i];
            int randomIndex = Random.Range(i, FoodPrefabs.Count);
            FoodPrefabs[i] = FoodPrefabs[randomIndex];
            FoodPrefabs[randomIndex] = temp;
        }
    }

    public void FoodEject()
    {
        if(EjectableFood == null) { return; }
        foreach (GameObject obj in EjectableFood)
        {
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            Vector3 direction = forceSource.transform.position - obj.transform.position;
            float force = Random.Range(minForce, maxForce);
            rb.AddForce(direction.normalized * force);
            obj.transform.position = ejectTransform.position;
        }
        EjectableFood.Clear();
    }
}
