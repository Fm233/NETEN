using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutMap : MonoBehaviour
{
    public Action<Note> noteAction { get; set; }
    
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }
    
    public void ReceiveLoadLevelAsset(LoadLevelAsset loadLevelAsset)
    {
        // Fill receiver function here
    }
    
}
