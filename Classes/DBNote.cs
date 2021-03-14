using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class DBNote
{
    List<Note> elements = new List<Note>();
    
    public void ReceiveModelCrtNote(ModelCrtNote modelCrtNote)
    {
        elements.Add(modelCrtNote.val);
    }
    
    public void ReceiveModelDelNote(ModelDelNote modelDelNote)
    {
        elements.RemoveAll(modelDelNote.sel);
    }
    
    public void ReceiveModelGetNote(ModelGetNote modelGetNote)
    {
        List<Note> res = new List<Note>();
        foreach (Note e in elements)
        {
            if (modelGetNote.sel(e))
           {
                res.Add(e);
            }
        }
        modelGetNote.ret(res);
    }
}
