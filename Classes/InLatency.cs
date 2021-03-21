using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class InLatency : MonoBehaviour
{
    public Action<ModelInLatencyToUseLatency> modelInLatencyToUseLatencyAction { get; set; }

    // TODO TimeInf get latency

    TimeInf time;

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
        float realTime = time.time;
        float gridedTime = Util.GridToSong(time.song, realTime, 1);
        modelInLatencyToUseLatencyAction(new ModelInLatencyToUseLatency(gridedTime - realTime));
    }

    public void ReceiveTimeInf(TimeInf timeInf)
    {
        time = timeInf;
    }
    
}
