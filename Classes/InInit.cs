using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class InInit : MonoBehaviour
{
    public Action<ModelInInitToUseInitSong> modelInInitToUseInitSongAction { get; set; }

    List<Song> songs = new List<Song>();

    public void Start()
    {
        // Start here
        RegisterSong("Fracture Ray", "Sakuzyo", 200, 0, 0, 146);
        RegisterSong("Freefall", "Au5", 134, 0, 28, 176);
        RegisterSong("The Chasm", "Crystal Skies", 128, 0, 9, 130);
        modelInInitToUseInitSongAction(new ModelInInitToUseInitSong(songs.ToArray()));
    }
    public void Update()
    {
        // Update here
    }

    void RegisterSong(string name, string author, float bpm, float offset, float start, float end)
    {
        songs.Add(new Song(name, author, Resources.Load<AudioClip>("Audios/" + name), bpm, offset, start, end));
    }

    public Action<ModelInInitToUseInitLevel> modelInInitToUseInitLevelAction { get; set; }
    
}
