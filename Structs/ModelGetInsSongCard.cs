using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ModelGetInsSongCard
{
    public Predicate<InsSongCard> sel;
    public Action<List<InsSongCard>> ret;

    public ModelGetInsSongCard(Predicate<InsSongCard> sel, Action<List<InsSongCard>> ret)
    {
        this.sel = sel;
        this.ret = ret;
    }
}
