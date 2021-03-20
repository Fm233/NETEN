using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutGame : MonoBehaviour
{
    public GameObject menu;
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelOutGame(ModelOutGame modelOutGame)
    {
        menu.SetActive(modelOutGame.show);
    }

}
