using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class UseJukeTime : IMB
{
    public Action<ModelGetLatency> modelGetLatencyAction { get; set; }
    
    public Action<ModelUseJukeTimeToOutJukeTime> modelUseJukeTimeToOutJukeTimeAction { get; set; }
    
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }
    
    public void ReceiveModelInJukeTimeToUseJukeTime(ModelInJukeTimeToUseJukeTime modelInJukeTimeToUseJukeTime)
    {
        // Fill receiver function here
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}
