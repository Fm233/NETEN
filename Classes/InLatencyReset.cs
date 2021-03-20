using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class InLatencyReset : MonoBehaviour
{
    public Action<ModelInLatencyResetToUseLatencyReset> modelInLatencyResetToUseLatencyResetAction { get; set; }

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void Trigger()
    {
        modelInLatencyResetToUseLatencyResetAction(new ModelInLatencyResetToUseLatencyReset());
    }
    
}
