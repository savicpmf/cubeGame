using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void STARTGAME()
    {

        SceneManager.LoadScene(1);
    }

    public void STARTARCADE()
    {
         SceneManager.LoadScene("ARCADE");
    }
}

