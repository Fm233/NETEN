using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class InsNote : MonoBehaviour, IModelOutFailToInsNoteReceiver
{
    public Action<ModelInsNoteToInHP> modelInsNoteToInHPAction { get; set; }
    
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }
    
    public void ReceiveModelOutFailToInsNote(ModelOutFailToInsNote modelOutFailToInsNote)
    {
        // Fill receiver function here
    }
    
    
    
    
    
    
    
    
    
    
    
    
}
