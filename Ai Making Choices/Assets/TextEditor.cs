using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;
using System.Data.Common;

public class TextEditor : MonoBehaviour
{
    public string text;
    public TextMeshProUGUI textMeshPro;
    public float writeSpeed;
    public bool inMotion = false;
    public enum Eeffect 
    {
        eNode,
        eWawe,
        eShake
    }
    public enum Eedit
    {
        eEffect,
        eColour,
        eSpeed
    }
    public struct WordChip
    {
        public char item;
        public Eeffect effect;
        public float speed;
    }
    public List<WordChip> chips;
    void Start()
    {
        chips = new List<WordChip>();
        //textMeshPro.text = text;
        textMeshPro.text = string.Empty;
    }

    void Update()
    {
        textMeshPro.ForceMeshUpdate();
        TMP_TextInfo textinfo = textMeshPro.textInfo;
        //Debug.Log("mesh: " + textinfo.characterCount);
        for (int i = 0; i < textinfo.characterCount; i++)
        {
            TMP_CharacterInfo charinfo = textinfo.characterInfo[i];
            
            if (!charinfo.isVisible) //so we can ignore space
            {
                continue;
            }

            Vector3[] verts = textinfo.meshInfo[charinfo.materialReferenceIndex].vertices;

            switch (chips[i].effect)
            {
                case Eeffect.eNode:
                    break;
                case Eeffect.eWawe:
                    for (int j = 0; j < 4; j++)
                    {
                        Vector3 original = verts[charinfo.vertexIndex + j];
                        verts[charinfo.vertexIndex + j] = original + new Vector3(0, (float)(10 * Math.Sin((double)Time.time * 2f + (original.x * 0.01f))), 0);
                    }
                    break;
                case Eeffect.eShake:
                    break;
                default:
                    break;
            }
        }
        for (int i = 0; i < textinfo.meshInfo.Length; i++) //updating text
        {
            TMP_MeshInfo meshinfo = textinfo.meshInfo[i];
            meshinfo.mesh.vertices = meshinfo.vertices;
            textMeshPro.UpdateGeometry(meshinfo.mesh,i);

        }
    }
    public void newline(string line)
    {
        inMotion = true;
        chips.Clear();
        textMeshPro.text = string.Empty;
        text = line;
        StartCoroutine(WriteLine());
    }
    IEnumerator WriteLine() 
    {
        Eeffect defult = Eeffect.eNode;
        Eeffect curent = defult;
        string local = text;
        bool editor = false;
        Eedit eType = Eedit.eEffect;

        foreach (char c in local.ToCharArray()) //set up text
        {
            if (editor)
            {
                if (c == 'e')
                {
                    eType = Eedit.eEffect;
                }
                else if (c == 'c')
                {
                    eType = Eedit.eColour;
                }
                else if (c == 's')
                {
                    eType = Eedit.eSpeed;
                }
                else if (char.IsDigit(c))
                {
                    switch (eType)
                    {
                        case Eedit.eEffect:
                            curent = (Eeffect)char.GetNumericValue(c);
                            break;
                        case Eedit.eColour:
                            //to add
                            break;
                        case Eedit.eSpeed:
                            //to add
                            break;
                    }
                }
                else if (c == '>')
                {
                    editor = false;
                }
                else
                {
                    Debug.Log("Error: Incorect text input for dialog");
                }
            }
            else
            {
                if (c == '<')
                {
                    editor = true;
                }
                else if (c == '\n')
                {
                    Debug.Log("break");
                    continue;
                }
                else
                {
                    WordChip newChip = new WordChip();
                    newChip.item = c;
                    newChip.effect = curent;
                    newChip.speed = writeSpeed;
                    chips.Add(newChip);
                }
            }
        }
        foreach (WordChip c in chips)  //slowly write it down
        {
            if (!inMotion)
            {
                textMeshPro.text += c.item;
                continue;
            }
            textMeshPro.text += c.item;
            yield return new WaitForSeconds(c.speed);
        }
        inMotion = false;
    }
}
