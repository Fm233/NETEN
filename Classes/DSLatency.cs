using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class DSLatency
{
    Latency element;
    
    public void ReceiveModelSetLatency(ModelSetLatency modelSetLatency)
    {
        element = modelSetLatency.val;
    }
    
    public void ReceiveModelGetLatency(ModelGetLatency modelGetLatency)
    {
        modelGetLatency.ret(element);
    }
}
