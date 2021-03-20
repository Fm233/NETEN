using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ConMenuState : IMB
{
    public Action<MenuState> menuStateAction { get; set; }

    public void Start()
    {
        menuStateAction(MenuState.MENU);
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveMenuState(MenuState menuState)
    {
        menuStateAction(menuState);
    }

}
