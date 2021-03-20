using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class InMenuLatency : MonoBehaviour
{
    public Action<MenuState> menuStateAction { get; set; }

    public Action<ModelInMenuLatencyToConMenuLatency> modelInMenuLatencyToConMenuLatencyAction { get; set; }

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
        menuStateAction(MenuState.LATENCY);
        modelInMenuLatencyToConMenuLatencyAction(new ModelInMenuLatencyToConMenuLatency());
    }

}
