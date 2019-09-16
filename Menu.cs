using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject RestartPannel;

    public void GoToGameScene()     //load 1st lvl from menu
    {
        SceneManager.LoadScene("Lvl");
    }

    public void Restart()       //restart lvl
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);       
    }

    public void GameOver()      //stop time and open lose pannel
    {
        Time.timeScale = 0f;
        RestartPannel.SetActive(true);
    }

    public void GoToMainMenu()      //back to main menu
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToWin()       //open win scene if you win game
    {
        SceneMenager.LoadScene("Win");
    }

}
