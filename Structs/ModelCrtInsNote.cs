using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ModelCrtInsNote
{
    public Action<InsNote> ret;

    public ModelCrtInsNote(Action<InsNote> ret)
    {
        this.ret = ret;
    }
}
