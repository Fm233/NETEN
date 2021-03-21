using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class UseInitLevel : IMB
{
    public Action<ModelGetLevel> modelGetLevelAction { get; set; }
    
    public Action<ModelCrtInsLevelCard> modelCrtInsLevelCardAction { get; set; }
    
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }
    
    public void ReceiveModelInInitToUseInitLevel(ModelInInitToUseInitLevel modelInInitToUseInitLevel)
    {
        // Fill receiver function here
    }
    
}
