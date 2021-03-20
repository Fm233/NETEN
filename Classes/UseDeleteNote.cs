using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class UseDeleteNote : IMB
{
    public Action<ModelDelNote> modelDelNoteAction { get; set; }
    
    public Action<ModelGetLatency> modelGetLatencyAction { get; set; }
    
    public Action<ModelUseDeleteNoteToOutDeleteNote> modelUseDeleteNoteToOutDeleteNoteAction { get; set; }
    
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }
    
    public void ReceiveModelInDeleteNoteToUseDeleteNote(ModelInDeleteNoteToUseDeleteNote modelInDeleteNoteToUseDeleteNote)
    {
        // Fill receiver function here
    }
    
}
