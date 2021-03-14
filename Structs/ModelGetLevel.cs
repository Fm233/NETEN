using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ModelGetLevel
{
    public Predicate<Level> sel;
    public Action<List<Level>> ret;

    public ModelGetLevel(Predicate<Level> sel, Action<List<Level>> ret)
    {
        this.sel = sel;
        this.ret = ret;
    }
}
