using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ConSetSong : IMB
{
    public Action<ModelConSetSongToUseSetSong> modelConSetSongToUseSetSongAction { get; set; }

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelConMenuEditToConSetSong(ModelConMenuEditToConSetSong modelConMenuEditToConSetSong)
    {
        // Fill receiver function here
    }

    public void ReceiveModelConLoadLevelToConSetSong(ModelConLoadLevelToConSetSong modelConLoadLevelToConSetSong)
    {
        // Fill receiver function here
    }
    
    
    
}
