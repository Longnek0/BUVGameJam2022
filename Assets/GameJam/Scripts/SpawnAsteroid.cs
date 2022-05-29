using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid : MonoBehaviour
{
    public float rate;
    public GameObject[] asteroids;
    public int waves;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAsteroids", rate, rate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAsteroids()
    {
        for (int i = 0; i < waves; i++)
        {
            Instantiate(asteroids[(int)Random.Range(0, asteroids.Length)], new Vector3(Random.Range(-2.5f, 2.5f), 8f, 1), Quaternion.identity);
        }
    }
 
}
