using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> carPrefabs;
    [SerializeField] private Transform spawnPrefabTransform;
    [SerializeField] private Quaternion spawnRot;
    public Vector3 spawnPos;
    public bool buttonPressed;

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
    }
    public void SpawnCar(int index)
    {
        Instantiate(carPrefabs[index], spawnPos, spawnRot);
    }
}
