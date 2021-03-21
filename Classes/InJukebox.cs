using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class InJukebox : MonoBehaviour
{
    public Action<JukeOp> jukeOpAction { get; set; }

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void Play()
    {
        jukeOpAction(JukeOp.PLAY);
    }

    public void Pause()
    {
        jukeOpAction(JukeOp.PAUSE);
    }

    public void Stop()
    {
        jukeOpAction(JukeOp.STOP);
    }

}
