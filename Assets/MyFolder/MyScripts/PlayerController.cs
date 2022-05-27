using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject PlayerShip;
    public GameObject projectile;
    public GameObject projectileCopy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        fire();
    }
    void movement()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(-5 * Time.deltaTime, 0, 0));
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0, 5 * Time.deltaTime, 0));
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(0, -5 * Time.deltaTime, 0));
        }
    }
    void fire()
    {
        if(Input.GetKeyDown(KeyCode.Space) /*&& projectileCopy == null*/)
        {
            projectileCopy = Instantiate(projectile,new Vector3(PlayerShip.transform.position.x,PlayerShip.transform.position.y + 0.6f, 2),PlayerShip.transform.rotation) as GameObject;
        }
    }
}
