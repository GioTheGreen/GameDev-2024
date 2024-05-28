using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class Return_node : Base_node {
    [Input] public int entry;
    public override void refresh()
    {
        type = "Return";
    }
}