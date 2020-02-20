using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathRespawn : MonoBehaviour
{
    public GameObject player;
    public GameObject test_dead;

    private PlayerMovement movementScript;

    private float playerPosX, playerPosY, playerPosZ;


    // Start is called before the first frame update
    void Start()
    {
        test_dead.SetActive(false);
        movementScript = player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        playerPosX = player.transform.position.x;
        playerPosY = player.transform.position.y;
        playerPosZ = player.transform.position.z;
    }

    //Checking for collison
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Spikes")
        {
            StartCoroutine("deadSpikes");
        }

        if (collision.tag == "Lava")
        {
            StartCoroutine("deadLava");
        }
    }

    //Death on spikes
    private IEnumerator deadSpikes()
    {
        movementScript.enabled = false;
        gameObject.GetComponent<Renderer>().enabled = false;
        test_dead.transform.position = new Vector3(playerPosX, playerPosY, playerPosZ);
        test_dead.SetActive(true);
        yield return new WaitForSeconds(3);
        test_dead.SetActive(false);
        transform.position = new Vector3(0, 0, 0);
        gameObject.GetComponent<Renderer>().enabled = true;
        movementScript.enabled = true;
    }

    //Death on lava
    private IEnumerator deadLava()
    {
        movementScript.enabled = false;
        gameObject.GetComponent<Renderer>().enabled = false;
        test_dead.transform.position = new Vector3(playerPosX, playerPosY, playerPosZ);
        test_dead.SetActive(true);
        yield return new WaitForSeconds(3);
        test_dead.SetActive(false);
        transform.position = new Vector3(0, 0, 0);
        gameObject.GetComponent<Renderer>().enabled = true;
        movementScript.enabled = true;
    }
}