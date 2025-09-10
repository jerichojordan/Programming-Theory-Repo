using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> carPrefabs;
    [SerializeField] private Transform spawnPrefabTransform;
    [SerializeField] private Quaternion spawnRot;
    private Vector3 spawnPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPos = spawnPrefabTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnCar(0);
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            SpawnCar(1);
        }else if (Input.GetButtonDown("Fire3"))
        {
            SpawnCar(2);
        }else if (Input.GetButtonDown("Jump"))
        {
            SpawnCar(3);
        }
    }
    public void SpawnCar(int index)
    {
        Instantiate(carPrefabs[index], spawnPos, spawnRot);
    }
    public void SpawnCar()
    {
        Instantiate(carPrefabs[Random.Range(0,carPrefabs.Count)], spawnPos, spawnRot);
    }
}
