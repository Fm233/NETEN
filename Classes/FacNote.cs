using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class FacNote : MonoBehaviour
{
    List<InsNote> elements = new List<InsNote>();
    public GameObject prefab;
    public OutFail outFail;
    
    public void ReceiveModelCrtInsNote(ModelCrtInsNote modelCrtInsNote)
    {
        GameObject instance = Instantiate(prefab);
        InsNote comp = instance.GetComponent<InsNote>();
        elements.Add(comp);
        outFail.modelOutFailToInsNoteAction += comp.ReceiveModelOutFailToInsNote;
        modelCrtInsNote.ret(comp);
    }
    
    public void ReceiveModelDelInsNote(ModelDelInsNote modelDelInsNote)
    {
        List<InsNote> toDelete = new List<InsNote>();
        foreach (InsNote e in elements)
        {
            if (modelDelInsNote.sel(e))
            {
                toDelete.Add(e);
            }
        }
        foreach (InsNote d in toDelete)
        {
            elements.Remove(d);
            d.gameObject.SetActive(false); // TODO Destroy
        }
    }
}
