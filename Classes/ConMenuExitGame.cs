using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ConMenuExitGame : IMB
{
    public Action<ModelOutMenu> modelOutMenuAction { get; set; }

    public Action<ModelOutGame> modelOutGameAction { get; set; }

    public Action<ModelConMenuExitGameToOutClear> modelConMenuExitGameToOutClearAction { get; set; }

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelInMenuExitGameToConMenuExitGame(ModelInMenuExitGameToConMenuExitGame modelInMenuExitGameToConMenuExitGame)
    {
        modelConMenuExitGameToOutClearAction(new ModelConMenuExitGameToOutClear());
        modelOutGameAction(new ModelOutGame(false));
        modelOutMenuAction(new ModelOutMenu(true));
    }

    public Action<ModelOutC> modelOutCAction { get; set; }
    
    public Action<ModelOutClear> modelOutClearAction { get; set; }
    
}
