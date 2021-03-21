using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutInitSong : MonoBehaviour
{
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelUseInitSongToOutInitSong(ModelUseInitSongToOutInitSong modelUseInitSongToOutInitSong)
    {
        Song[] songs = modelUseInitSongToOutInitSong.songs;
        for (int i = 0; i < songs.Length; i++)
        {
            Song song = songs[i];
            modelCrtInsSongCardAction(new ModelCrtInsSongCard((InsSongCard card) =>
            {
                card.transform.position = Vector3.up * i;
                card.SetSong(song.name);
            }));
        }
    }

    public Action<ModelCrtInsSongCard> modelCrtInsSongCardAction { get; set; }

}
