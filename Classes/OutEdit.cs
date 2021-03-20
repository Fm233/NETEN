using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutEdit : MonoBehaviour
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

    public void ReceiveModelOutEdit(ModelOutEdit modelOutEdit)
    {
        menu.SetActive(modelOutEdit.show);
    }

}
