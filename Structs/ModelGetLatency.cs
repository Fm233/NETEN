using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ModelGetLatency
{
    public Action<Latency> ret;

    public ModelGetLatency(Action<Latency> ret)
    {
        this.ret = ret;
    }
}
