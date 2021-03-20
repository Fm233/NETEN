using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutWin : MonoBehaviour
{
    public GameObject winUI;
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelInWinToOutWin(ModelInWinToOutWin modelInWinToOutWin)
    {
        winUI.SetActive(true);
    }

}
