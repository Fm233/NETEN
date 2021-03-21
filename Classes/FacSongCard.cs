using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class FacSongCard : MonoBehaviour
{
    List<InsSongCard> elements = new List<InsSongCard>();
    public GameObject prefab;
    public InMenuEdit inMenuEdit;
    
    public void ReceiveModelCrtInsSongCard(ModelCrtInsSongCard modelCrtInsSongCard)
    {
        GameObject instance = Instantiate(prefab);
        InsSongCard comp = instance.GetComponent<InsSongCard>();
        elements.Add(comp);
        comp.modelInsSongCardToInMenuEditAction += inMenuEdit.ReceiveModelInsSongCardToInMenuEdit;
        modelCrtInsSongCard.ret(comp);
    }
    
    public void ReceiveModelGetInsSongCard(ModelGetInsSongCard modelGetInsSongCard)
    {
        List<InsSongCard> res = new List<InsSongCard>();
        foreach (InsSongCard e in elements)
        {
            if (modelGetInsSongCard.sel(e))
           {
                res.Add(e);
            }
        }
        modelGetInsSongCard.ret(res);
    }
}
