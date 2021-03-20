using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class UseNoteKiller : IMB
{
    public Action<ModelUseNoteKillerToUseHP> modelUseNoteKillerToUseHPAction { get; set; }
    
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }
    
    public void ReceiveModelUseLoadLevelToUseNoteKiller(ModelUseLoadLevelToUseNoteKiller modelUseLoadLevelToUseNoteKiller)
    {
        // Fill receiver function here
    }
    
    public void ReceiveModelInNet(ModelInNet modelInNet)
    {
        // Fill receiver function here
    }
    
}
