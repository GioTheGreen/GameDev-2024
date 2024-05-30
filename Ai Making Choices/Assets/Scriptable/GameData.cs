using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "SaveData")]
public class GameData : ScriptableObject
{
    public bool firstPlay = true;
    public bool Boy = true;

    public int menu = 0;
}
