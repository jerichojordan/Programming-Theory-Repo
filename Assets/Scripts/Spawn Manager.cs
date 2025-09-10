using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> carPrefabs;
    [SerializeField] private Vector3 spawnPos;
    [SerializeField] private Quaternion spawnRot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnCar(int index)
    {
        Instantiate(carPrefabs[index], spawnPos, spawnRot);
    }
}
