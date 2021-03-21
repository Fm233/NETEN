using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class FacLevelCard : MonoBehaviour
{
    List<InsLevelCard> elements = new List<InsLevelCard>();
    public GameObject prefab;
    public InMenuGame inMenuGame;
    
    public void ReceiveModelCrtInsLevelCard(ModelCrtInsLevelCard modelCrtInsLevelCard)
    {
        GameObject instance = Instantiate(prefab);
        InsLevelCard comp = instance.GetComponent<InsLevelCard>();
        elements.Add(comp);
        comp.modelInsLevelCardToInMenuGameAction += inMenuGame.ReceiveModelInsLevelCardToInMenuGame;
        modelCrtInsLevelCard.ret(comp);
    }
    
    public void ReceiveModelGetInsLevelCard(ModelGetInsLevelCard modelGetInsLevelCard)
    {
        List<InsLevelCard> res = new List<InsLevelCard>();
        foreach (InsLevelCard e in elements)
        {
            if (modelGetInsLevelCard.sel(e))
           {
                res.Add(e);
            }
        }
        modelGetInsLevelCard.ret(res);
    }
}
