using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    public GameData gameData;
    public void OnClickBoy() 
    {
        gameData.Boy = true;
        gameData.firstPlay = false;
        SceneManager.LoadScene("OpenWorld");
    }
    public void OnClickGirl()
    {
        gameData.Boy = false;
        gameData.firstPlay = false;
        SceneManager.LoadScene("OpenWorld");
    }
    public void OnClickBack()
    {
        gameData.firstPlay = true;
        SceneManager.LoadScene("MainMenu");
    }
}
