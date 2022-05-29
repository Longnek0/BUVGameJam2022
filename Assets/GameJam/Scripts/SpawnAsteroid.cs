using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid : MonoBehaviour
{
    public bool Activation = false;
    public float rate;
    public GameObject[] asteroids;
    public int waves;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SpawnAsteroids()
    {
       
            for (int i = 0; i < waves; i++)
            {
                Instantiate(asteroids[(int)Random.Range(0, asteroids.Length)], new Vector3(Random.Range(-2.5f, 2.5f), 8f, 1), Quaternion.identity);
            }
       

    }
    public void FirstWave()
    {

        StartCoroutine(ActivateSpawn());
    }
    public void WaveUpdate()
    {
        StartCoroutine(RateDecrease());

    }

    IEnumerator RateDecrease()
    {
        yield return new WaitForSeconds(65f);

        InvokeRepeating("SpawnAsteroids", 2, 1);

        yield return new WaitForSeconds(60f);

        InvokeRepeating("SpawnAsteroids", 4, 1);

        yield return new WaitForSeconds(60f);

        InvokeRepeating("SpawnAsteroids", 8, 1);

    }

    IEnumerator ActivateSpawn()
    {
        yield return new WaitForSeconds(10f);

        InvokeRepeating("SpawnAsteroids", rate, rate);
        Activation = true;
    }

}
