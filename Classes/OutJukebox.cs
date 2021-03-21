using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Stopwatch = System.Diagnostics.Stopwatch;
public class OutJukebox : MonoBehaviour
{
    public AudioSource audioSource;
    Song song;
    Stopwatch timer = new Stopwatch();
    bool paused = false;
    float offsetTime;
    float time
    {
        get
        {
            return (float)timer.Elapsed.TotalSeconds;
        }
    }
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        timeInfAction(new TimeInf(song, time));
    }

    public void ReceiveModelInJukeMoveToOutJukebox(ModelInJukeMoveToOutJukebox modelInJukeMoveToOutJukebox)
    {
        PlayAt(modelInJukeMoveToOutJukebox.time);
    }

    public void ReceiveJukeOp(JukeOp jukeOp)
    {
        if (jukeOp == JukeOp.PLAY)
        {
            Play();
        }
        if (jukeOp == JukeOp.PAUSE)
        {
            Pause();
        }
        if (jukeOp == JukeOp.STOP)
        {
            Stop();
        }
    }

    void Play()
    {
        audioSource.Play();
        timer.Start();
    }
    void PlayAt(float sec)
    {
        audioSource.Play((ulong)(audioSource.clip.frequency * sec));
        timer.Restart();
        offsetTime = sec;
    }
    void Pause()
    {
        audioSource.Pause();
        timer.Stop();
    }
    void Stop()
    {
        audioSource.Stop();
        timer.Reset();
        offsetTime = 0;
    }

    public void ReceiveModelInJukeSpeedToOutJukebox(ModelInJukeSpeedToOutJukebox modelInJukeSpeedToOutJukebox)
    {
        audioSource.pitch = modelInJukeSpeedToOutJukebox.speed;
    }

    public void ReceiveModelOutSetSong(ModelOutSetSong modelOutSetSong)
    {
        song = modelOutSetSong.song;
        audioSource.clip = modelOutSetSong.song.clip;
        offsetTime = 0;
        Play();
    }

    public Action<TimeInf> timeInfAction { get; set; }

}
