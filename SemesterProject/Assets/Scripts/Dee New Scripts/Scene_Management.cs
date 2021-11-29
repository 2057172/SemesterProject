using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene_Management : MonoBehaviour
{
   public void howtoplay()
    {
        SceneManager.LoadScene("how_to_Play");
    }
    public void inGame()
    {
        SceneManager.LoadScene("Final_in game");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void endGame()
    {

        SceneManager.LoadScene("gameOver_scene");
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }

}
