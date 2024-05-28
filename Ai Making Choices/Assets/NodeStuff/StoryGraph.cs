using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;
using XNode;

[CreateAssetMenu]
public class StoryGraph : NodeGraph {
	public string TreeName;
	public Base_node currnt;

    public void Restart()
    {
        foreach (Base_node node in nodes) 
        {
            node.refresh();
            node.done = false;
            if (node.getType() == "Start")
            {
                currnt = node;
            }
        }
    }
    public void next(int ans = 0)
    {
        switch (currnt.getType())
        {
            case "Start":
                foreach (NodePort port in currnt.Ports)
                {
                    if (port.fieldName == "exit")
                    {
                        if (port.ConnectionCount > 0)
                        {
                            currnt = port.Connection.node as Base_node;
                        }
                        else
                        {
                            Debug.Log("start_node: no valed conection");
                        }
                    }
                }
                break;
            case "Level":
                break;
            case "Question":
                Question_node question = currnt as Question_node;
                string portname;
                switch (ans)
                {
                    case 0:
                        portname = "A1";
                        break;
                    case 1:
                        portname = "A2";
                        break;
                    case 2:
                        portname = "A3";
                        break;
                    case 3:
                        portname = "A4";
                        break;
                    default:
                        portname = "A1";
                        Debug.Log("Incorrect answer amount");
                        break;
                }
                foreach (NodePort port in question.Ports)
                {
                    if (port.fieldName == portname)
                    {
                        if (port.ConnectionCount > 0)
                        {
                            currnt = port.Connection.node as Base_node;
                        }
                        else
                        {
                            Debug.Log("Question_node: no valed conection");
                        }
                    }
                }
                break;
            case "Show":
                foreach (NodePort port in currnt.Ports)
                {
                    if (port.fieldName == "exit")
                    {
                        if (port.ConnectionCount > 0)
                        {
                            currnt = port.Connection.node as Base_node;
                        }
                        else
                        {
                            Debug.Log("show_node: no valed conection");
                        }
                    }
                }
                break;
            case "Tree":
                break;
            case "Return":
                break;
            default:
                Debug.Log("Error: incorrect or unknown node type");
                break;
        }
    }

}