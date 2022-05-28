using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceShip : MonoBehaviour
{
    public Text levelUp, maxLevel, livesUp; 
    GameObject a,b;
    int level = 1;
    public GameObject bullet, explosion, bulletLv2, bulletLv3;
    public Rigidbody2D rb;
    public float speed;
    public int health = 3;
    int delay = 0;
    public bool canShoot = true;
    public float shootingTime = 0.5f;
    public bool rampageMode = false;
    public AudioClip shootingSound;
    public AudioClip explode;
    public AudioClip livesUpp;
    public AudioClip levelUpp;

    void Awake()
    {
        rb.GetComponent<Rigidbody2D>();
        a = transform.Find("0").gameObject;
        b = transform.Find("1").gameObject; 
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Health", health);
        levelUp.gameObject.SetActive(false);
        maxLevel.gameObject.SetActive(false);
        livesUp.gameObject.SetActive(false);
        //rampageText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector2(Input.GetAxis("Horizontal")*speed,0));
        rb.AddForce(new Vector2(0, Input.GetAxis("Vertical") * speed));

        if(Input.GetKey(KeyCode.Space) && canShoot == true)
        {
            StartCoroutine(Shoot());
        }

        delay++;

        
    }
    
    public void Damage()
    {
        health--;
        PlayerPrefs.SetInt("Health", health);
        StartCoroutine(Blink());
        if(health == 0)
        {
            Instantiate(explosion, this.transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(explode, this.transform.position);
            Destroy(gameObject, 0.1f);
        }
    }

    public void AddHealth()
    {
        health++;
        StartCoroutine(LivesUp());
        PlayerPrefs.SetInt("Health", health);
    }

    public void AddLevel()
    {
        level++;
        if(level == 2)
        {
            shootingTime = 0.4f;
            StartCoroutine(LoadLevelUp());

        }
        else if(level >= 3)
        {
            shootingTime = 0.3f;
            StartCoroutine(LoadMaxLevel());
        }
    }

    //public void RampageOn()
    //{
    //    StartCoroutine(Rampage());
    //}
    //
    void OnTriggerEnter2D(Collider2D col)
    {  
        if(col.gameObject.tag == "Homing")
        {
            GameObject.Find("BigBoss").GetComponent<BossAttack2>().CheckForLastMissiles();
            StartCoroutine(StopFiring());
        }

    }


    IEnumerator Blink()
    {
        GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
        yield return new WaitForSeconds(0.1f);
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
    }

    IEnumerator LoadLevelUp()
    {
        levelUp.gameObject.SetActive(true);
        AudioSource.PlayClipAtPoint(levelUpp, this.transform.position);
        yield return new WaitForSeconds(1f);
        levelUp.gameObject.SetActive(false);
    }

    IEnumerator LoadMaxLevel()
    {
        maxLevel.gameObject.SetActive(true);
        AudioSource.PlayClipAtPoint(levelUpp, this.transform.position);
        yield return new WaitForSeconds(1f);
        maxLevel.gameObject.SetActive(false);
    }

    IEnumerator LivesUp()
    {
       livesUp.gameObject.SetActive(true);
        AudioSource.PlayClipAtPoint(livesUpp, this.transform.position);
        yield return new WaitForSeconds(1f);
        livesUp.gameObject.SetActive(false);
    }

    IEnumerator Shoot()
    {
        if (level == 1)
        {
            Instantiate(bullet, a.transform.position, Quaternion.identity);
            Instantiate(bullet, b.transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(shootingSound, this.transform.position);
        }

        else if (level == 2)
        {
            Instantiate(bulletLv2, a.transform.position, Quaternion.identity);
            Instantiate(bulletLv2, b.transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(shootingSound, this.transform.position);
        }

        else if (level >= 3)
        {
            Instantiate(bulletLv3, a.transform.position, Quaternion.identity);
            Instantiate(bulletLv3, b.transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(shootingSound, this.transform.position);
        }

        canShoot = false;
        yield return new WaitForSeconds(shootingTime);
        canShoot = true;

    }
    
    IEnumerator StopFiring()
    {
        canShoot = false;
        yield return new WaitForSeconds(6f);
        canShoot = true;
    }
    
}
