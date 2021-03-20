using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ConMenuExitLatency : IMB
{
    public Action<ModelOutMenu> modelOutMenuAction { get; set; }

    public Action<ModelOutLatency> modelOutLatencyAction { get; set; }

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelInMenuExitLatencyToConMenuExitLatency(ModelInMenuExitLatencyToConMenuExitLatency modelInMenuExitLatencyToConMenuExitLatency)
    {
        modelOutMenuAction(new ModelOutMenu(true));
        modelOutLatencyAction(new ModelOutLatency(false));
    }

}
