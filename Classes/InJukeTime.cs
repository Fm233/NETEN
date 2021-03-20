using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class InJukeTime : MonoBehaviour
{
    AudioSource audioSource;

    Song song;

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }
    public Action<ModelInJukeTimeToUseJukeTime> modelInJukeTimeToUseJukeTimeAction { get; set; }

    public void ReceiveModelOutSetSong(ModelOutSetSong modelOutSetSong)
    {
        song = modelOutSetSong.song;
    }

    public void ReceiveTimeInf(TimeInf timeInf)
    {
        modelInJukeTimeToUseJukeTimeAction(new ModelInJukeTimeToUseJukeTime(timeInf));
    }

}
