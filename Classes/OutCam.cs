using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutCam : MonoBehaviour
{
    public Camera cam;
    bool avaliable = false;
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveMenuState(MenuState menuState)
    {
        if (menuState == MenuState.EDIT || menuState == MenuState.GAME)
        {
            avaliable = true;
        }
        else
        {
            avaliable = false;
        }
    }

    public void ReceiveModelOutJukeTime(ModelOutJukeTime modelOutJukeTime)
    {
        if (avaliable)
        {
            cam.transform.position = Vector3.forward * modelOutJukeTime.time * Const.CAMERA_MOVE_SPEED;
        }
    }

}
