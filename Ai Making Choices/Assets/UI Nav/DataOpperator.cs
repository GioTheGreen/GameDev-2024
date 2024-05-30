using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataOpperator : MonoBehaviour
{
    public GameData CurrentSave;
    public GameObject m1;
    public GameObject m2;
    public GameObject m3;
    public GameObject m4;
    void Start()
    {
        switch (CurrentSave.menu)
        {
            case 0:
                m1.SetActive(true);
                m2.SetActive(false);
                m3.SetActive(false);
                m4.SetActive(false);
                break;
            case 1:
                m1.SetActive(false);
                m2.SetActive(true);
                m3.SetActive(false);
                m4.SetActive(false);
                break;
            case 2:
                m1.SetActive(false);
                m2.SetActive(false);
                m3.SetActive(true);
                m4.SetActive(false);
                break;
            case 3:
                m1.SetActive(false);
                m2.SetActive(false);
                m3.SetActive(false);
                m4.SetActive(true);
                break;
            default:
                break;
        }
    }

    public void onBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void setMenu(int menu)
    {
       CurrentSave.menu = menu;
    }
}
