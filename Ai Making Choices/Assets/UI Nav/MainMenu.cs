using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameData gameData;
    public void StartGame()
    {
        
        if (gameData.firstPlay)
        {
            SceneManager.LoadScene("CharacterSelect");
        }
        else
        {
            SceneManager.LoadScene("OpenWorld");
        }
    }
    public void ExitGame() 
    {
        Application.Quit();
    }
}
