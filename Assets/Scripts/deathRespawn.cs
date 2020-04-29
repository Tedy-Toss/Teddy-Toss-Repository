using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathRespawn : MonoBehaviour
{
    public GameObject player;
    //public GameObject test_dead;
    public GameObject Laser;
    public GameObject LaserBottom;
    public GameObject LaserTop;
    public bool isdead = false;
    public Rigidbody2D rb;
    public Animator animator;

    private PlayerMovement movementScript;

    private float playerPosX, playerPosY, playerPosZ;
    private int timer = 0;


    // Start is called before the first frame update
    void Start()
    {
        //test_dead.SetActive(false);
        Laser.SetActive(false);
        LaserBottom.SetActive(false);
        LaserTop.SetActive(false);
        movementScript = player.GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerPosX = player.transform.position.x;
        playerPosY = player.transform.position.y;
        playerPosZ = player.transform.position.z;

        timer++;
        if (timer > 60)
        {
            StartCoroutine("laser");
        }
    }

    //Checking for collison
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Spikes")
        {
            StartCoroutine("deadSpikes");
            Debug.Log("hi");
        }

        if (collision.tag == "Lava")
        {
            StartCoroutine("deadLava");
        }

        if (collision.tag == "Laser")
        {
            StartCoroutine("deadLaser");
        }

        if (collision.tag == "LaserTop")
        {
            StartCoroutine("deadLaser");
        }

        if (collision.tag == "LaserBottom")
        {
            StartCoroutine("deadLaser");
        }
    }

    private IEnumerator laser()
    {
        Laser.SetActive(true);
        LaserBottom.SetActive(true);
        LaserTop.SetActive(true);
        yield return new WaitForSeconds(3);
        timer = 0;
        Laser.SetActive(false);
        LaserBottom.SetActive(false);
        LaserTop.SetActive(false);
    }

    //Death on spikes
    private IEnumerator deadSpikes()
    {
        isdead = true;
        animator.SetBool("IsDead", true);
        rb.velocity = new Vector2(0f, 0f);
        rb.gravityScale = 0;
        movementScript.enabled = false;
        //gameObject.GetComponent<Renderer>().enabled = false;
        //test_dead.transform.position = new Vector3(playerPosX, playerPosY - 0.8f, playerPosZ);
        //test_dead.SetActive(true);
        yield return new WaitForSeconds(3);
        //test_dead.SetActive(false);
        transform.position = new Vector3(-6, -3, 0);
        //gameObject.GetComponent<Renderer>().enabled = true;
        movementScript.enabled = true;
        rb.gravityScale = 4;
        animator.SetBool("IsDead", false);
        isdead = false;
    }

    //Death on lava
    private IEnumerator deadLava()
    {
        isdead = true;
        animator.SetBool("IsDead", true);
        rb.velocity = new Vector2(0f, 0f);
        rb.gravityScale = 0;
        movementScript.enabled = false;
        //gameObject.GetComponent<Renderer>().enabled = false;
        //test_dead.transform.position = new Vector3(playerPosX, playerPosY - 0.5f, playerPosZ);
       // test_dead.SetActive(true);
        yield return new WaitForSeconds(3);
        //test_dead.SetActive(false);
        transform.position = new Vector3(-6, -3, 0);
        //gameObject.GetComponent<Renderer>().enabled = true;
        movementScript.enabled = true;
        rb.gravityScale = 4;
        animator.SetBool("IsDead", false);
        isdead = false;
    }

    private IEnumerator deadLaser()
    {
        isdead = true;
        animator.SetBool("IsDead", true);
        rb.velocity = new Vector2(0f, 0f);
        rb.gravityScale = 0;
        movementScript.enabled = false;
        //gameObject.GetComponent<Renderer>().enabled = false;
        //test_dead.transform.position = new Vector3(playerPosX, playerPosY, playerPosZ);
        //test_dead.SetActive(true);
        yield return new WaitForSeconds(3);
        //test_dead.SetActive(false);
        transform.position = new Vector3(-6, -3, 0);
        //gameObject.GetComponent<Renderer>().enabled = true;
        movementScript.enabled = true;
        rb.gravityScale = 4;
        animator.SetBool("IsDead", false);
        isdead = false;
    }
}