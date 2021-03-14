using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ModelCrtInsNote
{
    public InsNote val;
    public Action<InsNote> ret;

    public ModelCrtInsNote(InsNote val, Action<InsNote> ret)
    {
        this.val = val;
        this.ret = ret;
    }
}
