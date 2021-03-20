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
        modelGetLatencyAction(new ModelGetLatency((Latency latency) =>
        {
            float realTime = modelInJukeTimeToUseJukeTime.timeInf.time + latency.l;
            float gridedTime = Util.GridToSong(modelInJukeTimeToUseJukeTime.timeInf.song, realTime, 4);
            // TODO Grid custom
            modelUseJukeTimeToOutJukeTimeAction(new ModelUseJukeTimeToOutJukeTime(new TimeInf(modelInJukeTimeToUseJukeTime.timeInf.song, gridedTime)));
        }));
    }

}
