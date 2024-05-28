using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
//using UnityEditor.Experimental.GraphView;
//using UnityEditor.ShortcutManagement;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using XNode;

public class Director : MonoBehaviour
{
    public StoryGraph story;
    public Sprite[] BG;
    public Sprite replay;
    public Sprite[] CharSprites;
    public GameObject buttonClass;
    public string[] charName;

    public Image Current_BG;
    public Image char1;
    public Image char2;
    public TextMeshProUGUI Name;
    public TextEditor Dialog;
    public GameObject DialogContainor;
    public GameObject QuestionContainor;
    public List<GameObject> buttons;


    //private int4 p1mode1 = new int4(585,190,585,0);
    //private int4 p1mode2 = new int4(585, 190, 585, 0);

    void Start()
    {
        story.Restart();
    }

    void Update()
    {
        switch (story.currnt.getType())
        {
            case "Start":
                story.next();
                break;
            case "Level":
               
                    break;
            case "Question":
                Question_node question = story.currnt as Question_node;
                if (!question.done)
                {
                    question.done = true;
                    DialogContainor.SetActive(false);
                    QuestionContainor.SetActive(true);
                    if (question.ansNum >= 2)
                    {
                        buttons.Add(Instantiate(buttonClass, QuestionContainor.transform,false));
                        buttons.Add(Instantiate(buttonClass, QuestionContainor.transform, false));
                        buttons[0].GetComponentInChildren<TextMeshProUGUI>().text = question.Q1;
                        buttons[1].GetComponentInChildren<TextMeshProUGUI>().text = question.Q2;
                    }
                    if (question.ansNum >= 3)
                    {
                        buttons.Add(Instantiate(buttonClass, QuestionContainor.transform, false));
                        buttons[2].GetComponentInChildren<TextMeshProUGUI>().text = question.Q3;
                    }
                    if(question.ansNum == 4)
                    {
                        buttons.Add(Instantiate(buttonClass, QuestionContainor.transform, false));
                        buttons[3].GetComponentInChildren<TextMeshProUGUI>().text = question.Q4;
                    }
                }
                for (int i = 0; i < buttons.Count; i++)
                {
                    if (buttons[i].GetComponent<CheckPressed>().pressed)
                    {
                        story.next(i);

                        foreach (GameObject b in buttons)
                        {
                            Destroy(b);
                        }
                        buttons.Clear();
                        break;
                    }
                }
                    break;
            case "Show":
                Show_node show = story.currnt as Show_node;
                switch (show.mode)
                {
                    case Show_node.Emode.one:
                        if (!show.done)
                        {
                            DialogContainor.SetActive(true);
                            QuestionContainor.SetActive(false);
                            Dialog.newline(show.Dialog);
                            show.done = true;
                            Current_BG.sprite = BG[(int)show.map];
                            char1.sprite = CharSprites[(int)show.chacactor];
                            char1.rectTransform.position = new Vector3(0, -95, 0)+ char1.rectTransform.parent.position;//(585,0,850,890);
                            char1.color = new Color(255, 255, 255, 255);
                            char2.color = new Color(255,255,255,0);
                            Name.text = charName[(int)show.chacactor];
                        }
                        break;
                    case Show_node.Emode.two:
                        if (!show.done)
                        {
                            DialogContainor.SetActive(true);
                            QuestionContainor.SetActive(false);
                            Dialog.newline(show.Dialog);
                            show.done = true;
                            Current_BG.sprite = BG[(int)show.map];
                            char1.sprite = CharSprites[(int)show.chacactor];
                            char1.rectTransform.position = new Vector3(-485, -95, 0) + char1.rectTransform.parent.position; // new (100, 0, 850, 890);
                            char2.sprite = CharSprites[(int)show.chacactor2];
                            if (show.first)
                            {
                                char1.color = new Color32(255, 255, 255, 255);
                                char2.color = new Color32(135, 135, 135, 255);
                                Name.text = charName[(int)show.chacactor];
                            }
                            else
                            {
                                char1.color = new Color32(135, 135, 135, 255);
                                char2.color = new Color32(255, 255, 255, 255);
                                Name.text = charName[(int)show.chacactor2];
                            }
                        }
                        break;
                    default:
                        break;
                }
                if (Input.GetMouseButtonDown(0))
                {
                    if (show.done && !Dialog.inMotion)
                    {
                        story.next();
                    }
                    else if (Dialog.inMotion)
                    {
                        Dialog.inMotion = false;
                    }
                }
                break;
            case "Tree":
                Tree_node tree = story.currnt as Tree_node;
                if (!tree.done)
                {
                    char1.color = new Color(255, 255, 255, 0);
                    char2.color = new Color(255, 255, 255, 0);
                    DialogContainor.SetActive(false);
                    QuestionContainor.SetActive(false);

                    Current_BG.sprite = replay;
                }
                if (Input.GetMouseButtonDown(0))
                {
                    story.Restart();
                }
                break;
            case "Return":
                break;
            default:
                Debug.Log("Error: incorrect or unknown node type");
                break;
        }
    }
}
