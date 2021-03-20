using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutJukeTime : MonoBehaviour
{
    public Action<ModelOutJukeTime> modelOutJukeTimeAction { get; set; }

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelUseJukeTimeToOutJukeTime(ModelUseJukeTimeToOutJukeTime modelUseJukeTimeToOutJukeTime)
    {
        modelOutJukeTimeAction(new ModelOutJukeTime(modelUseJukeTimeToOutJukeTime.timeInf.time));
    }

}
