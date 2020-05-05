using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public int index;
    public void Select(string LevelName)
    {
        SceneManager.LoadScene(LevelName);
    }
}