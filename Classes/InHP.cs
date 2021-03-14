using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class InHP : MonoBehaviour
{
    public Action<QuitType> quitTypeAction { get; set; }

    public Action<ModelInHPToOutHP> modelInHPToOutHPAction { get; set; }
    float hp;

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelInsNoteToInHP(ModelInsNoteToInHP modelInsNoteToInHP)
    {
        hp += modelInsNoteToInHP.amount;
        modelInHPToOutHPAction(new ModelInHPToOutHP(hp));
        if (hp < 0)
        {
            quitTypeAction(QuitType.FAIL);
        }
    }

    public void ReceiveModelConMenuGameToInHP(ModelConMenuGameToInHP modelConMenuGameToInHP)
    {
        hp = 10;
    }
    
    
    
    
    
    
    
    
}
