using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class UseHP : IMB
{
    public Action<ModelOutFail> modelOutFailAction { get; set; }
    
    public Action<ModelUseHPToOutHP> modelUseHPToOutHPAction { get; set; }
    
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }
    
    public void ReceiveModelUseNoteKillerToUseHP(ModelUseNoteKillerToUseHP modelUseNoteKillerToUseHP)
    {
        // Fill receiver function here
    }
    
    public Action<ModelUseHPToOutFail> modelUseHPToOutFailAction { get; set; }
    
}
