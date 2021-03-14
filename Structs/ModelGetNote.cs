using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ModelGetNote
{
    public Predicate<Note> sel;
    public Action<List<Note>> ret;

    public ModelGetNote(Predicate<Note> sel, Action<List<Note>> ret)
    {
        this.sel = sel;
        this.ret = ret;
    }
}
