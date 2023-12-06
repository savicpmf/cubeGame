using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float restartDelay = 2f;

    public bool hasEnded = false;

    public GameObject LevelCompleteUI;

    public GameObject ArcadeUI;

    public void EndGame()
    {
        if (hasEnded == false)
        {
            if (SceneManager.GetActiveScene().name == "ARCADE")
            {
                ArcadeUI.SetActive(true);
            }
            else
            {
                hasEnded = true;
                Debug.Log("Game over");
                Invoke("Restart", restartDelay);
            }
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LevelComplete()
    {
        Debug.Log("Level complete");
        LevelCompleteUI.SetActive(true);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
