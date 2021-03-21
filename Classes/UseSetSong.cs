using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class UseSetSong : IMB
{
    public Action<ModelGetSong> modelGetSongAction { get; set; }

    public Action<ModelUseSetSongToOutSetSong> modelUseSetSongToOutSetSongAction { get; set; }

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelConSetSongToUseSetSong(ModelConSetSongToUseSetSong modelConSetSongToUseSetSong)
    {
        modelGetSongAction(new ModelGetSong((Song song) =>
        {
            return song.name == modelConSetSongToUseSetSong.songName;
        }, (List<Song> list) =>
        {
            if (list != null && list.Count > 0)
            {
                modelUseSetSongToOutSetSongAction(new ModelUseSetSongToOutSetSong(list[0]));
            }
        }));
    }
}
