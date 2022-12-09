using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//access scenemanager and allows acces to other scenes
public class MainMenu : MonoBehaviour
{
    //These public voids have different variables and each one will load a different scene 
    public void GameStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Level1()
    {
        SceneManager.LoadScene("first");
    }

    public void Level2()
    {
        SceneManager.LoadScene("second");
    }

    public void Level3()
    {
        SceneManager.LoadScene("third");
    }

    public void GameStartAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Start menu");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
