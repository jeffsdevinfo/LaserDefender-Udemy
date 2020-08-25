using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] float delayInSeconds = 2f;
    Coroutine WaitBeforeEndScreen;

    public void LoadStartMenu()
    {
        //Load something based on the scene index
        SceneManager.LoadScene(0);
        Debug.Log("Start Menu has been clicked");

    }

    public void LoadMainGame()
    {
        //Load something based on the name of the scene
        // String references are not necessarily good because if the
        // name changes in the ui editor then the reference will be broken
        
        SceneManager.LoadScene("Game");
        Debug.Log("Start Game has been clicked");
        GameSession session = FindObjectOfType<GameSession>();
        session.ResetGame();
    }

   IEnumerator SleepBeforeEnding()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("Game Over");
        Debug.Log("End Game has been happended");
    }

    public void LoadGameOver()
    {
        WaitBeforeEndScreen = StartCoroutine(SleepBeforeEnding());
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game has been clicked");
    }
}
