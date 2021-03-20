using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ConMenuEdit : IMB
{
    public Action<ModelOutMenu> modelOutMenuAction { get; set; }

    public Action<ModelOutEdit> modelOutEditAction { get; set; }

    public Action<ModelConMenuEditToConSetSong> modelConMenuEditToConSetSongAction { get; set; }

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelInMenuEditToConMenuEdit(ModelInMenuEditToConMenuEdit modelInMenuEditToConMenuEdit)
    {
        modelConMenuEditToConSetSongAction(new ModelConMenuEditToConSetSong(modelInMenuEditToConMenuEdit.songName));
        modelOutEditAction(new ModelOutEdit(true));
        modelOutMenuAction(new ModelOutMenu(false));
    }

}
