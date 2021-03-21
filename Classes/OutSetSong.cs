using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutSetSong : MonoBehaviour
{

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelUseSetSongToOutSetSong(ModelUseSetSongToOutSetSong modelUseSetSongToOutSetSong)
    {
        modelOutSetSongAction(new ModelOutSetSong(modelUseSetSongToOutSetSong.song));
    }

    public Action<ModelOutSetSong> modelOutSetSongAction { get; set; }

}
