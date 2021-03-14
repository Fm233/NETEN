using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class LoadLevelAsset
{
    public Level level;
    public Latency latency;

    public LoadLevelAsset(Level level, Latency latency)
    {
        this.level = level;
        this.latency = latency;
    }
}
