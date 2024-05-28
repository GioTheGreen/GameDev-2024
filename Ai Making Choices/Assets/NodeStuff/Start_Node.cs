using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class Start_Node : Base_node
{
    [Output]public int exit;
    public override void refresh()
    {
        type = "Start";
    }
}