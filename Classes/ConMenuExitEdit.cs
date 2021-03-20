using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ConMenuExitEdit : IMB
{
    public Action<ModelOutMenu> modelOutMenuAction { get; set; }

    public Action<ModelOutEdit> modelOutEditAction { get; set; }

    public Action<ModelConMenuExitEditToConAbortLevel> modelConMenuExitEditToConAbortLevelAction { get; set; }

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelInMenuExitEditToConMenuExitEdit(ModelInMenuExitEditToConMenuExitEdit modelInMenuExitEditToConMenuExitEdit)
    {
        modelConMenuExitEditToConAbortLevelAction(new ModelConMenuExitEditToConAbortLevel());
        modelOutEditAction(new ModelOutEdit(false));
        modelOutMenuAction(new ModelOutMenu(true));
    }

}
