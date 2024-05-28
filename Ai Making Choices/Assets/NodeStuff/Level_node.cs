using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class Level_node : Base_node
{
    [Input] public int entry;
    [Output] public int exit;
    public enum Elevel
    {
        eLevel1,
        eLevel2
    }
    public Elevel Level;
    public override void refresh()
    {
        type = "Level";
    }
}