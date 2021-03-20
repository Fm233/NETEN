using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class UseCreateNote : IMB
{
    public Action<ModelCrtNote> modelCrtNoteAction { get; set; }
    
    public Action<ModelGetLatency> modelGetLatencyAction { get; set; }
    
    public Action<Note> noteAction { get; set; }
    
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }
    
    public void ReceiveNote(Note note)
    {
        // Fill receiver function here
    }
    
}
