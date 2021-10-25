using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform spawnPoint;
    private float timer;
    public float SpawnTimer = 0.5f;

    void Start()
    {
        timer = SpawnTimer;
    }
    void Update()
    {

        if (timer < 0)
        {
            Shoot();
        }

        timer -= Time.deltaTime;
     
    }

    private void Shoot()
    {
        timer = SpawnTimer;
        Instantiate(projectilePrefab, spawnPoint.position, transform.rotation); 
    
    }
}
