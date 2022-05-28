using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public GameObject[] healthbar;

    public int health;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 1)
        {
            healthbar[0].SetActive(true);
            healthbar[1].SetActive(false);
            healthbar[2].SetActive(false);
            healthbar[3].SetActive(false);
            healthbar[4].SetActive(false);
            healthbar[5].SetActive(false);
        }
        else if (health == 2)
        {
            healthbar[0].SetActive(false);
            healthbar[1].SetActive(true);
            healthbar[2].SetActive(false);
            healthbar[3].SetActive(false);
            healthbar[4].SetActive(false);
            healthbar[5].SetActive(false);
        }
        else if (health == 3)
        {
            healthbar[0].SetActive(false);
            healthbar[1].SetActive(false);
            healthbar[2].SetActive(true);
            healthbar[3].SetActive(false);
            healthbar[4].SetActive(false);
            healthbar[5].SetActive(false);
        }
        else if (health == 4)
        {
            healthbar[0].SetActive(false);
            healthbar[1].SetActive(false);
            healthbar[2].SetActive(false);
            healthbar[3].SetActive(true);
            healthbar[4].SetActive(false);
            healthbar[5].SetActive(false);
        }
        else if (health == 5)
        {
            healthbar[0].SetActive(false);
            healthbar[1].SetActive(false);
            healthbar[2].SetActive(false);
            healthbar[3].SetActive(false);
            healthbar[4].SetActive(true);
            healthbar[5].SetActive(false);
        }
        else if (health == 0)
        {
            healthbar[0].SetActive(false);
            healthbar[1].SetActive(false);
            healthbar[2].SetActive(false);
            healthbar[3].SetActive(false);
            healthbar[4].SetActive(false);
            healthbar[5].SetActive(true);
        }
    }
}
