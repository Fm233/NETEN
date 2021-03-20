using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class InWin : MonoBehaviour
{
    public AudioSource audioSource;

    Song song;

    MenuState state;

    public Action<ModelInWinToOutWin> modelInWinToOutWinAction { get; set; }

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        if (state == MenuState.GAME && audioSource.time > song.end)
        {
            modelInWinToOutWinAction(new ModelInWinToOutWin());
        }
    }

    public void ReceiveModelOutSetSong(ModelOutSetSong modelOutSetSong)
    {
        song = modelOutSetSong.song;
    }

    public void ReceiveMenuState(MenuState menuState)
    {
        state = menuState;
    }
    
    public void ReceiveTimeInf(TimeInf timeInf)
    {
        // Fill receiver function here
    }
    
}
