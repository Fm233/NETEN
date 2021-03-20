using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Util
{
    public static float GridToSong(Song song, float time, int div)
    {
        float bps = song.bpm / 60 * div;
        float originatedTime = time - song.offset;
        int beats = Mathf.RoundToInt(originatedTime * bps);
        float extendedTime = beats / bps;
        return extendedTime + song.offset;
    }

    public static Latency AddLatency(Latency old, float add)
    {
        float avg = (old.l * old.count + add) / (old.count + 1);
        return new Latency(avg, old.count + 1);
    }
}
