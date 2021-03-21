using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ConSetSong : IMB
{
    public Action<ModelConSetSongToUseSetSong> modelConSetSongToUseSetSongAction { get; set; }

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelConSetSong(ModelConSetSong modelConSetSong)
    {
        modelConSetSongToUseSetSongAction(new ModelConSetSongToUseSetSong(modelConSetSong.songName));
    }
}
