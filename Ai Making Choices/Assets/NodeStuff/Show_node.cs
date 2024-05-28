using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class Show_node : Base_node
{
    [Input] public int entry;
    [Output] public int exit;
    public enum Emode
    {
        one,
        two
    }
    public Emode mode;
    public enum Echaractor
    {
        eTest1,
        eTest2,
        eTest3
    }
    public enum Eexprestion
    {
        eNormal,
        eHappy,
        eSad
    }
    public Echaractor chacactor;
    public Eexprestion exprestion;
    public Echaractor chacactor2;
    public Eexprestion exprestion2;
    public bool first = true;
    public enum Emap
    {
        eMap1,
        eMap2
    }
    public Emap map;
    [TextArea(3, 20)]
    public string Dialog;
    public override void refresh()
    {
        type = "Show";
        done = false;
    }
}