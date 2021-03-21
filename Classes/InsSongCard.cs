using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class InsSongCard : MonoBehaviour
{
    public Action<ModelInsSongCardToInMenuEdit> modelInsSongCardToInMenuEditAction { get; set; }

    string songName;

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    private void OnMouseDown()
    {
        modelInsSongCardToInMenuEditAction(new ModelInsSongCardToInMenuEdit(songName));
    }

    public void SetSong(string sn)
    {
        songName = sn;
    }
    
}
