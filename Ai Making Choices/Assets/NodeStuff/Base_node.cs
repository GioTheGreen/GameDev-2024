using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class Base_node : Node {

    protected string type;
    public bool done;

    public virtual void refresh()
    {
        type = "Base";
    }
    public string getType()
    {
            return type;
    }
}