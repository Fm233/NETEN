using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class InsLevelCard : MonoBehaviour
{
    public Action<ModelInsLevelCardToInMenuGame> modelInsLevelCardToInMenuGameAction { get; set; }

    string songName;
    string levelName;

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
        modelInsLevelCardToInMenuGameAction(new ModelInsLevelCardToInMenuGame(songName, levelName));
    }

    public void SetLevel(string sn, string ln)
    {
        songName = sn;
        levelName = ln;
    }
    
}
