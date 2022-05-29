using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FollowMouse : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Transform leftBorder;
    [SerializeField]
    private Transform rightBorder;
    [SerializeField]
    private float maxSpeed;
    [SerializeField] private HealthManager hm;
    public bool canMove = false;
    public Pause pause;
    public bool takeOff; //changed based on level
    public bool isShielded;
    public bool GameStarted = false;

    [SerializeField] public GameObject shield;
    [SerializeField] public float shieldDur;
    public SpawnAsteroid spawner;
    public bool canUseShield;
    public GameObject BackGround;
    // Start is called before the first frame update
    void Start()
    {
        canUseShield = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && GameStarted == false)
        {
            GameStarted = true;
            takeOff = true;
            //spawner.SpawnAsteroids();
            spawner.FirstWave();
            spawner.WaveUpdate();
            BackGround.GetComponent<Animator>().enabled = true;
        }
        mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.y = -2.85f;
        mouseWorldPosition.z = 0f;
        if (Input.GetKeyDown(KeyCode.Q) && canUseShield==true)
        {
            StartCoroutine(ShieldSkill());
        }
       
        if (canMove == true)
        {
            //Check for when player reach left border
            if ( mouseWorldPosition.x <=- 2.5 )
            {
                Cursor. visible = true;
                this.transform.position = rightBorder.transform.position;
            }
            //Check for when player reach right border
            else if ( mouseWorldPosition.x >= 2.5 )
            {
                Cursor. visible = true;
                this.transform.position = leftBorder.transform.position;
            }
            //Check for when player is in the middle 
            else if (mouseWorldPosition.x >= -2.5 && mouseWorldPosition.x <= 2.5)
            {
                Cursor. visible = false;
                transform.position = Vector2.MoveTowards(transform.position, mouseWorldPosition, maxSpeed*Time.deltaTime);
                //transform.position = mouseWorldPosition;
            }
        }

        if (takeOff == true)
        {
           
            StartCoroutine(SetupJet());
        }
        
        if (hm.health <= 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("GameOver");
            Cursor.visible = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (isShielded == true)
        {
            
        }
        else if (isShielded == false)
        {
            if (col.gameObject.tag == "Rock")
            {
                hm.health -= 1;
            }
            else if (col.gameObject.tag == "Asteroid")
            {
                hm.health -= 2;
            }
            else if (col.gameObject.tag == "Potion")
            {
                hm.health += 1;
            }
        }
        
    }

    public IEnumerator SetupJet()
    {
        canMove = false;
        yield return new WaitForSeconds(6);
        takeOff = false;
        canMove = true;
    }
    public IEnumerator ShieldSkill()
    {
        canUseShield = false;
        isShielded = true;
        shield.SetActive(true);
        yield return new WaitForSeconds(3);
        shield.SetActive(false);
        isShielded = false;
        yield return new WaitForSeconds(15);
        canUseShield = true;
    }
}
