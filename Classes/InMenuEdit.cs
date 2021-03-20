using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class InMenuEdit : MonoBehaviour
{

    public Action<MenuState> menuStateAction { get; set; }

    public Action<ModelInMenuEditToConMenuEdit> modelInMenuEditToConMenuEditAction { get; set; }

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void Trigger(string songName)
    {
        menuStateAction(MenuState.EDIT);
        modelInMenuEditToConMenuEditAction(new ModelInMenuEditToConMenuEdit(songName));
    }

}
