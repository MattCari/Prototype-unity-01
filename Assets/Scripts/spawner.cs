using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    private float spawningFurtherZ = 181f;
    float z;
    float x;
    public Vector3 spawnPoint;
    public GameObject vehicle;
    private float timer = 0;
    public float timeTillNextSpawn = 3;
    // Start is called before the first frame update
    void Start()
    {
        z = spawningFurtherZ;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Spawn();
    }
    private void Spawn()
    {
        if(timer > timeTillNextSpawn)
        {
            x = Random.Range(-5.5f, 9);
            spawnPoint = new Vector3(x, 0, z);
            Instantiate(vehicle, spawnPoint, Quaternion.Euler(0f,180f,0f));
            timer = 0;
        }
    }
}
