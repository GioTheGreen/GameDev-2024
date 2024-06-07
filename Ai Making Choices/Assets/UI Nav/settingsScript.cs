using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class settingsScript : MonoBehaviour
{
    public GameData gameData;
    public Slider sliderMV;
    public Slider sliderM;
    public Slider sliderSFX;

    private bool frezze_code = false;
    private void Start()
    {
        updateMenu();
    }
    public void deleteEverything()
    {
        frezze_code = true;
        //gameData = ScriptableObject.CreateInstance<GameData>();
        gameData.defult();
        updateMenu();
        frezze_code = false;
        SceneManager.LoadScene("MainMenu");
    }
    public void updateData()
    {
        if (!frezze_code)
        {
            gameData.MasterVolume = (int)sliderMV.value;
            gameData.Music = (int)sliderM.value;
            gameData.SoundFX = (int)sliderSFX.value;
        }
    }

    public void updateMenu()
    {
        sliderMV.value = gameData.MasterVolume;
        sliderM.value = gameData.Music;
        sliderSFX.value = gameData.SoundFX;
    }
}
