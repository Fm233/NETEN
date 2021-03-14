using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ConMenuGame : IMB
{
    public Action<ModelOutMenu> modelOutMenuAction { get; set; }
    
    public Action<ModelOutGame> modelOutGameAction { get; set; }
    
    public Action<ModelConMenuGameToConLoadLevel> modelConMenuGameToConLoadLevelAction { get; set; }
    
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }
    
    public void ReceiveModelInMenuGameToConMenuGame(ModelInMenuGameToConMenuGame modelInMenuGameToConMenuGame)
    {
        // Fill receiver function here
    }
    
    
    
    
    
    
    
    
    
    
    
    public Action<ModelConMenuGameToInHP> modelConMenuGameToInHPAction { get; set; }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}
