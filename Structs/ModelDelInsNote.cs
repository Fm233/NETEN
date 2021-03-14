using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ModelDelInsNote
{
    public Predicate<InsNote> sel;

    public ModelDelInsNote(Predicate<InsNote> sel)
    {
        this.sel = sel;
    }
}
