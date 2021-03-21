using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ModelCrtInsLevelCard
{
    public Action<InsLevelCard> ret;

    public ModelCrtInsLevelCard(Action<InsLevelCard> ret)
    {
        this.ret = ret;
    }
}
