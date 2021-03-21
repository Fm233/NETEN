using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class InMenuGame : MonoBehaviour
{
    public Action<MenuState> menuStateAction { get; set; }

    public Action<ModelInMenuGameToConMenuGame> modelInMenuGameToConMenuGameAction { get; set; }

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void Trigger(string sn, string ln)
    {
        menuStateAction(MenuState.GAME);
        modelInMenuGameToConMenuGameAction(new ModelInMenuGameToConMenuGame(sn, ln));
    }

    public void ReceiveModelInsLevelCardToInMenuGame(ModelInsLevelCardToInMenuGame modelInsLevelCardToInMenuGame)
    {
        Trigger(modelInsLevelCardToInMenuGame.songName, modelInsLevelCardToInMenuGame.levelName);
    }
    
}
