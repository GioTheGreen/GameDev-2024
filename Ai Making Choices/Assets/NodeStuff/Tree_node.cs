using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class Tree_node : Base_node
{
    [Input] public int entry;
    [Output] public int exit;
    public string Tree;
    public override void refresh()
    {
        type = "Tree";
    }
}