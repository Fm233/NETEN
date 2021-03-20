using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class UseInitSong : IMB
{
    public Action<ModelCrtSong> modelCrtSongAction { get; set; }
    
    public Action<ModelUseInitSongToOutInitSong> modelUseInitSongToOutInitSongAction { get; set; }
    
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }
    
    public void ReceiveModelInInitToUseInitSong(ModelInInitToUseInitSong modelInInitToUseInitSong)
    {
        // Fill receiver function here
    }
    
}
