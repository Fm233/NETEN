using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class UseLatencyReset : IMB
{
    public Action<ModelSetLatency> modelSetLatencyAction { get; set; }

    public Action<ModelUseLatencyResetToOutLatency> modelUseLatencyResetToOutLatencyAction { get; set; }

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelInLatencyResetToUseLatencyReset(ModelInLatencyResetToUseLatencyReset modelInLatencyResetToUseLatencyReset)
    {
        modelSetLatencyAction(new ModelSetLatency(new Latency(0, 0)));
    }

    public Action<ModelUseLatencyResetToOutLatencyDisplay> modelUseLatencyResetToOutLatencyDisplayAction { get; set; }

}
