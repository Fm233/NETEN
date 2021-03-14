using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class Song
{
    public string name;
    public string author;
    public AudioClip clip;
    public float bpm;
    public float offset;
    public float start;
    public float end;

    public Song(string name, string author, AudioClip clip, float bpm, float offset, float start, float end)
    {
        this.name = name;
        this.author = author;
        this.clip = clip;
        this.bpm = bpm;
        this.offset = offset;
        this.start = start;
        this.end = end;
    }
}
