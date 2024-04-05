using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{

    public int playerScore;
    public Text Score;
    public GameObject gameOverScreen;
    public PlayerControllerScript pcs;

    [ContextMenu("addScore")]
    [ContextMenu("removeScore")]

    public void addScore()
    {
        playerScore++;
        Score.text = playerScore.ToString();
    }

    public void removeScore()
    {
        playerScore--;
        Score.text = playerScore.ToString();
    }

    public void restartGame()
    {
        Debug.Log("function called!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        pcs.isAlive = false;
    }
    
    public void backToMenu()
    {
        SceneManager.LoadScene("main-menu");
    }
}
