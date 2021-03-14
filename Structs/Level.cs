using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class Level
{
    public Note[] notes;
    public string songName;
    public string levelName;

    public Level(Note[] notes, string songName, string levelName)
    {
        this.notes = notes;
        this.songName = songName;
        this.levelName = levelName;
    }
}
