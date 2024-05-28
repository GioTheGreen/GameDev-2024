using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPressed : MonoBehaviour
{
    public bool pressed;
    public Button button;
    void Start()
    {
        pressed = false;
        button = GetComponent<Button>();
        button.onClick.AddListener(OnPressed);
    }

    public void OnPressed()
    {
        pressed = true;
    }
}
