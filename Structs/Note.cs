using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class Note
{
    public Vector2[] real;
    public Vector2[] display;
    public float time;

    public Note(Vector2[] real, Vector2[] display, float time)
    {
        this.real = real;
        this.display = display;
        this.time = time;
    }
}
