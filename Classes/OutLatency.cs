using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutLatency : MonoBehaviour
{
    public GameObject menu;
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelOutLatency(ModelOutLatency modelOutLatency)
    {
        menu.SetActive(modelOutLatency.show);
    }
    
}
