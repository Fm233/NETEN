using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutJukebox : MonoBehaviour
{
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }
    
    public void ReceiveModelInJukeMoveToOutJukebox(ModelInJukeMoveToOutJukebox modelInJukeMoveToOutJukebox)
    {
        // Fill receiver function here
    }
    
    public void ReceiveJukeOp(JukeOp jukeOp)
    {
        // Fill receiver function here
    }
    
    public void ReceiveModelInJukeSpeedToOutJukebox(ModelInJukeSpeedToOutJukebox modelInJukeSpeedToOutJukebox)
    {
        // Fill receiver function here
    }
    
    public void ReceiveModelOutSetSongToOutJukebox(ModelOutSetSongToOutJukebox modelOutSetSongToOutJukebox)
    {
        // Fill receiver function here
    }
    
    public Action<ModelOutJukeboxToInWin> modelOutJukeboxToInWinAction { get; set; }
    
    public void ReceiveModelOutSetSong(ModelOutSetSong modelOutSetSong)
    {
        // Fill receiver function here
    }
    
    public Action<TimeInf> timeInfAction { get; set; }
    
}
