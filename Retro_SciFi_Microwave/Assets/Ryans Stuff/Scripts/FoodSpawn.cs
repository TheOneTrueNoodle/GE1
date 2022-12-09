using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    [Header("List of Spawnable Foods")]
    [SerializeField] private List<GameObject> FoodPrefabs;
    [Header("List of Spawned Foods")]
    public List<GameObject> SpawnedFood;

    [Header("Food Spawning Values")]
    [SerializeField] private Transform spawnTransform;

    private int NextFood;

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
    }

    private void SpawnFood()
    {
        if(FoodPrefabs == null) { return; }

        GameObject newFood = Instantiate(FoodPrefabs[NextFood]);
        newFood.transform.position = spawnTransform.position;
        SpawnedFood.Add(newFood);

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
}
