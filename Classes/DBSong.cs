using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class DBSong
{
    List<Song> elements = new List<Song>();
    
    public void ReceiveModelCrtSong(ModelCrtSong modelCrtSong)
    {
        elements.Add(modelCrtSong.val);
    }
    
    public void ReceiveModelGetSong(ModelGetSong modelGetSong)
    {
        List<Song> res = new List<Song>();
        foreach (Song e in elements)
        {
            if (modelGetSong.sel(e))
           {
                res.Add(e);
            }
        }
        modelGetSong.ret(res);
    }
}
