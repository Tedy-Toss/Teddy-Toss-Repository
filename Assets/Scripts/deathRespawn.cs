using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathRespawn : MonoBehaviour
{
    public GameObject player;
    //blic GameObject test_dead;
    public GameObject Laser;
    public GameObject LaserBottom;
    public GameObject LaserTop;
    public bool isdead = false;
    public Rigidbody2D rb;
    public Animator animator;
    public GameObject Laser2;
    public GameObject LaserBottom2;
    public GameObject LaserTop2;
    public GameObject Laser3;
    public GameObject LaserBottom3;
    public GameObject LaserTop3;
    public GameObject Laser4;
    public GameObject LaserBottom4;
    public GameObject LaserTop4;
    public GameObject Laser5;
    public GameObject LaserBottom5;
    public GameObject LaserTop5;
    public GameObject Laser6;
    public GameObject LaserBottom6;
    public GameObject LaserTop6;
    public GameObject Laser7;
    public GameObject LaserBottom7;
    public GameObject LaserTop7;
    public GameObject Laser8;
    public GameObject LaserBottom8;
    public GameObject LaserTop8;
    public GameObject Laser9;
    public GameObject LaserBottom9;
    public GameObject LaserTop9;
    public GameObject Laser10;
    public GameObject LaserBottom10;
    public GameObject LaserTop10;
    public GameObject Laser11;
    public GameObject LaserBottom11;
    public GameObject LaserTop11;
    public GameObject Laser12;
    public GameObject LaserBottom12;
    public GameObject LaserTop12;
    public GameObject Laser13;
    public GameObject LaserBottom13;
    public GameObject LaserTop13;
    public GameObject Laser14;
    public GameObject LaserBottom14;
    public GameObject LaserTop14;
    public GameObject Laser15;
    public GameObject LaserBottom15;
    public GameObject LaserTop15;
    public GameObject Laser16;
    public GameObject LaserBottom16;
    public GameObject LaserTop16;
    public GameObject Laser17;
    public GameObject LaserBottom17;
    public GameObject LaserTop17;
    public GameObject Laser18;
    public GameObject LaserBottom18;
    public GameObject LaserTop18;

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
        Laser2.SetActive(false);
        LaserBottom2.SetActive(false);
        LaserTop2.SetActive(false);
        Laser3.SetActive(false);
        LaserBottom3.SetActive(false);
        LaserTop3.SetActive(false);
        Laser4.SetActive(false);
        LaserBottom4.SetActive(false);
        LaserTop4.SetActive(false);
        Laser5.SetActive(false);
        LaserBottom5.SetActive(false);
        LaserTop5.SetActive(false);
        Laser6.SetActive(false);
        LaserBottom6.SetActive(false);
        LaserTop6.SetActive(false);
        Laser7.SetActive(false);
        LaserBottom7.SetActive(false);
        LaserTop7.SetActive(false);
        Laser8.SetActive(false);
        LaserBottom8.SetActive(false);
        LaserTop8.SetActive(false);
        Laser9.SetActive(false);
        LaserBottom9.SetActive(false);
        LaserTop9.SetActive(false);
        Laser10.SetActive(false);
        LaserBottom10.SetActive(false);
        LaserTop10.SetActive(false);
        Laser11.SetActive(false);
        LaserBottom11.SetActive(false);
        LaserTop11.SetActive(false);
        Laser12.SetActive(false);
        LaserBottom12.SetActive(false);
        LaserTop12.SetActive(false);
        Laser13.SetActive(false);
        LaserBottom13.SetActive(false);
        LaserTop13.SetActive(false);
        Laser14.SetActive(false);
        LaserBottom14.SetActive(false);
        LaserTop14.SetActive(false);
        Laser15.SetActive(false);
        LaserBottom15.SetActive(false);
        LaserTop15.SetActive(false);
        Laser16.SetActive(false);
        LaserBottom16.SetActive(false);
        LaserTop16.SetActive(false);
        Laser17.SetActive(false);
        LaserBottom17.SetActive(false);
        LaserTop17.SetActive(false);
        Laser18.SetActive(false);
        LaserBottom18.SetActive(false);
        LaserTop18.SetActive(false);
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
        Laser2.SetActive(true);
        LaserBottom2.SetActive(true);
        LaserTop2.SetActive(true);
        Laser3.SetActive(true);
        LaserBottom3.SetActive(true);
        LaserTop3.SetActive(true);
        Laser4.SetActive(true);
        LaserBottom4.SetActive(true);
        LaserTop4.SetActive(true);
        Laser5.SetActive(true);
        LaserBottom5.SetActive(true);
        LaserTop5.SetActive(true);
        Laser6.SetActive(true);
        LaserBottom6.SetActive(true);
        LaserTop6.SetActive(true);
        Laser7.SetActive(true);
        LaserBottom7.SetActive(true);
        LaserTop7.SetActive(true);
        Laser8.SetActive(true);
        LaserBottom8.SetActive(true);
        LaserTop8.SetActive(true);
        Laser9.SetActive(true);
        LaserBottom9.SetActive(true);
        LaserTop9.SetActive(true);
        Laser10.SetActive(true);
        LaserBottom10.SetActive(true);
        LaserTop10.SetActive(true);
        Laser11.SetActive(true);
        LaserBottom11.SetActive(true);
        LaserTop11.SetActive(true);
        Laser12.SetActive(true);
        LaserBottom12.SetActive(true);
        LaserTop12.SetActive(true);
        Laser13.SetActive(true);
        LaserBottom13.SetActive(true);
        LaserTop13.SetActive(true);
        Laser14.SetActive(true);
        LaserBottom14.SetActive(true);
        LaserTop14.SetActive(true);
        Laser15.SetActive(true);
        LaserBottom15.SetActive(true);
        LaserTop15.SetActive(true);
        Laser16.SetActive(true);
        LaserBottom16.SetActive(true);
        LaserTop16.SetActive(true);
        Laser17.SetActive(true);
        LaserBottom17.SetActive(true);
        LaserTop17.SetActive(true);
        Laser18.SetActive(true);
        LaserBottom18.SetActive(true);
        LaserTop18.SetActive(true);
        yield return new WaitForSeconds(3);
        timer = 0;
        Laser.SetActive(false);
        LaserBottom.SetActive(false);
        LaserTop.SetActive(false);
        Laser2.SetActive(false);
        LaserBottom2.SetActive(false);
        LaserTop2.SetActive(false);
        Laser3.SetActive(false);
        LaserBottom3.SetActive(false);
        LaserTop3.SetActive(false);
        Laser4.SetActive(false);
        LaserBottom4.SetActive(false);
        LaserTop4.SetActive(false);
        Laser5.SetActive(false);
        LaserBottom5.SetActive(false);
        LaserTop5.SetActive(false);
        Laser6.SetActive(false);
        LaserBottom6.SetActive(false);
        LaserTop6.SetActive(false);
        Laser7.SetActive(false);
        LaserBottom7.SetActive(false);
        LaserTop7.SetActive(false);
        Laser8.SetActive(false);
        LaserBottom8.SetActive(false);
        LaserTop8.SetActive(false);
        Laser9.SetActive(false);
        LaserBottom9.SetActive(false);
        LaserTop9.SetActive(false);
        Laser10.SetActive(false);
        LaserBottom10.SetActive(false);
        LaserTop10.SetActive(false);
        Laser11.SetActive(false);
        LaserBottom11.SetActive(false);
        LaserTop11.SetActive(false);
        Laser12.SetActive(false);
        LaserBottom12.SetActive(false);
        LaserTop12.SetActive(false);
        Laser13.SetActive(false);
        LaserBottom13.SetActive(false);
        LaserTop13.SetActive(false);
        Laser14.SetActive(false);
        LaserBottom14.SetActive(false);
        LaserTop14.SetActive(false);
        Laser15.SetActive(false);
        LaserBottom15.SetActive(false);
        LaserTop15.SetActive(false);
        Laser16.SetActive(false);
        LaserBottom16.SetActive(false);
        LaserTop16.SetActive(false);
        Laser17.SetActive(false);
        LaserBottom17.SetActive(false);
        LaserTop17.SetActive(false);
        Laser18.SetActive(false);
        LaserBottom18.SetActive(false);
        LaserTop18.SetActive(false);
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
        transform.position = new Vector3(-7, 1, 0);
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
        transform.position = new Vector3(-7, 1, 0);
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
        transform.position = new Vector3(-7, 1, 0);
        //gameObject.GetComponent<Renderer>().enabled = true;
        movementScript.enabled = true;
        rb.gravityScale = 4;
        animator.SetBool("IsDead", false);
        isdead = false;
    }
}