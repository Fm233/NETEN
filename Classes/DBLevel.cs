using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class DBLevel
{
    List<Level> elements = new List<Level>();
    
    public void ReceiveModelCrtLevel(ModelCrtLevel modelCrtLevel)
    {
        elements.Add(modelCrtLevel.val);
    }
    
    public void ReceiveModelGetLevel(ModelGetLevel modelGetLevel)
    {
        List<Level> res = new List<Level>();
        foreach (Level e in elements)
        {
            if (modelGetLevel.sel(e))
           {
                res.Add(e);
            }
        }
        modelGetLevel.ret(res);
    }
}
