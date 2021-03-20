using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ConLoadLevel : IMB
{
    public Action<ModelConLoadLevelToUseLoadLevel> modelConLoadLevelToUseLoadLevelAction { get; set; }
    
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }
    
    public void ReceiveModelConMenuGameToConLoadLevel(ModelConMenuGameToConLoadLevel modelConMenuGameToConLoadLevel)
    {
        // Fill receiver function here
    }
    
    public Action<ModelConLoadLevelToConSetSong> modelConLoadLevelToConSetSongAction { get; set; }
    
}
