using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ModelGetSong
{
    public Predicate<Song> sel;
    public Action<List<Song>> ret;

    public ModelGetSong(Predicate<Song> sel, Action<List<Song>> ret)
    {
        this.sel = sel;
        this.ret = ret;
    }
}
