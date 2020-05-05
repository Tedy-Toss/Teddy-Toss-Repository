using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelNext : MonoBehaviour
{
    public int index;
    //ublic string levelName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            //laods scence 1
            SceneManager.LoadScene(index);

            //laod level with scene name
            // SceneManager.LoadScene("scene 2");

        }
    }
}
