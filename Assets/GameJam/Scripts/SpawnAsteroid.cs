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
        InvokeRepeating("SpawnAsteroids", rate, rate);
        

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(RateDecrease());
        StartCoroutine(ActivateSpawn());
    }

    void SpawnAsteroids()
    {
        if(Activation == true)
        {
            for (int i = 0; i < waves; i++)
            {
                Instantiate(asteroids[(int)Random.Range(0, asteroids.Length)], new Vector3(Random.Range(-2.5f, 2.5f), 8f, 1), Quaternion.identity);
            }
        }

    }

    IEnumerator RateDecrease()
    {
        yield return new WaitForSeconds(5f);
        
          rate -= 1f;

        yield return new WaitForSeconds(5f);
        
           rate -= 1f;

        yield return new WaitForSeconds(5f);

            rate -= 1f;

        yield return new WaitForSeconds(5f);

        rate -= 1f;
    }

    IEnumerator ActivateSpawn()
    {
        yield return new WaitForSeconds(15f);

        Activation = true;
    }
 
}
