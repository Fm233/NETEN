using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutFail : MonoBehaviour
{
    public Action<ModelOutFailToInsNote> modelOutFailToInsNoteAction { get; set; }

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelConQuitLevelToOutFail(ModelConQuitLevelToOutFail modelConQuitLevelToOutFail)
    {
        // Fill receiver function here
    }

    public void ReceiveModelOutFail(ModelOutFail modelOutFail)
    {
        // Fill receiver function here
    }
    
    public void ReceiveModelUseHPToOutFail(ModelUseHPToOutFail modelUseHPToOutFail)
    {
        // Fill receiver function here
    }
    
}
