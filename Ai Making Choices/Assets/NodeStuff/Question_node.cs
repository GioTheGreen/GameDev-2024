using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class Question_node : Base_node
{
    [Input] public int entry;
    public int ansNum = 2; // 2,3 or 4
    [TextArea(1, 20)]
    public string Q1;
    [Output] public int A1;
    public string Q2;
    [Output] public int A2;
    public string Q3;
    [Output] public int A3;
    public string Q4;
    [Output] public int A4;
    public override void refresh()
    {
        type = "Question";
    }
}