using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutMenu : MonoBehaviour
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

    public void ReceiveModelOutMenu(ModelOutMenu modelOutMenu)
    {
        menu.SetActive(modelOutMenu.show);
    }

}
