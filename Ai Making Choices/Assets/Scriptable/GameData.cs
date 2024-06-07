using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "SaveData")]
public class GameData : ScriptableObject
{
    public bool firstPlay = true;
    public bool Boy = true;

    //settings
    public int MasterVolume = 500;
    public int Music = 500;
    public int SoundFX = 500;

    public int menu = 0;
    public float Money = 50;
    public int day = 0;
    public int day_actions = 3;

    //acts
    public StoryGraph current;
    public bool tutorial_1 = false;
    public bool tutorial_2 = false;
    public bool tutorial_3 = false;
    public bool tutorial_4 = false;
    public bool wake_up_at_ally = false;
    public bool hospitel_1 = false;
    public bool trash_leadge = false;
    public bool unlock_shop = false;

    //fights
    public int TL = -1;
    public int RL = -1;
    public int PL = -1;
    public int PeL = -1;
    public int RU = -1;
    public int PU = -1;
    public int PeU = -1;


    public void defult()
    {
        firstPlay = true;
        Boy = true;

        //settings
        MasterVolume = 500;
        Music = 500;
        SoundFX = 500;

        menu = 0;
    }
}
