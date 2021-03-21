using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ModelCrtInsSongCard
{
    public Action<InsSongCard> ret;

    public ModelCrtInsSongCard(Action<InsSongCard> ret)
    {
        this.ret = ret;
    }
}
