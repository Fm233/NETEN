using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutClear : MonoBehaviour
{
    public Transform clearPad;
    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void ReceiveModelOutClear(ModelOutClear modelOutClear)
    {
        for (int i = 0; i < clearPad.childCount; i++)
        {
            clearPad.GetChild(i).gameObject.SetActive(false); // TODO Destroy?
        }
    }

}
