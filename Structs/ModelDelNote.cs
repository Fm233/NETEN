using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ModelDelNote
{
    public Predicate<Note> sel;

    public ModelDelNote(Predicate<Note> sel)
    {
        this.sel = sel;
    }
}
