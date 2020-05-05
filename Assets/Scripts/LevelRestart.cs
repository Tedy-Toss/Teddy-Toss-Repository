using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRestart : MonoBehaviour
{
    void doExitGame()
    {
        Application.Quit();
        Debug.Log("im quiting");
    }
}
