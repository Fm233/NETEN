using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class UseLoadLevel : IMB
{
    public Action<ModelGetLevel> modelGetLevelAction { get; set; }
    
    public Action<ModelGetLatency> modelGetLatencyAction { get; set; }
    
    public Action<LoadLevelAsset> loadLevelAssetAction { get; set; }
    
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }
    
    public void ReceiveModelConLoadLevelToUseLoadLevel(ModelConLoadLevelToUseLoadLevel modelConLoadLevelToUseLoadLevel)
    {
        // Fill receiver function here
    }
    
    public Action<ModelUseLoadLevelToUseNoteKiller> modelUseLoadLevelToUseNoteKillerAction { get; set; }
    
}
