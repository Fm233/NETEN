using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class UseLatency : IMB
{
    public Action<ModelSetLatency> modelSetLatencyAction { get; set; }

    public Action<ModelGetLatency> modelGetLatencyAction { get; set; }

    public Action<ModelUseLatencyToOutLatency> modelUseLatencyToOutLatencyAction { get; set; }

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelInLatencyToUseLatency(ModelInLatencyToUseLatency modelInLatencyToUseLatency)
    {
        modelGetLatencyAction(new ModelGetLatency((Latency latency) =>
        {
            modelSetLatencyAction(new ModelSetLatency(Util.AddLatency(latency, modelInLatencyToUseLatency.latency)));
        }));
    }

    public Action<ModelUseLatencyToOutLatencyDisplay> modelUseLatencyToOutLatencyDisplayAction { get; set; }

}
