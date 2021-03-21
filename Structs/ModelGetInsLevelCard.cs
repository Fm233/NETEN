using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ModelGetInsLevelCard
{
    public Predicate<InsLevelCard> sel;
    public Action<List<InsLevelCard>> ret;

    public ModelGetInsLevelCard(Predicate<InsLevelCard> sel, Action<List<InsLevelCard>> ret)
    {
        this.sel = sel;
        this.ret = ret;
    }
}
