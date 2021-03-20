using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
public class OutLatencyDisplay : MonoBehaviour
{
    public Text text;
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelUseLatencyToOutLatencyDisplay(ModelUseLatencyToOutLatencyDisplay modelUseLatencyToOutLatencyDisplay)
    {
        text.text = "Latency = " + modelUseLatencyToOutLatencyDisplay.latency + "s";
        // TODO Format
    }

    public void ReceiveModelUseLatencyResetToOutLatencyDisplay(ModelUseLatencyResetToOutLatencyDisplay modelUseLatencyResetToOutLatencyDisplay)
    {
        text.text = "Latency = 0s";
    }

}
