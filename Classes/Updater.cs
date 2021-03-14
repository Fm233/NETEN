using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class Updater : MonoBehaviour
{
    List<IMB> imbs = new List<IMB>();
    public void AddIMB(IMB imb)
    {
        imbs.Add(imb);
    }
    private void Start()
    {
        foreach (IMB imb in imbs)
        {
            imb.Start();
        }
    }
    private void Update()
    {
        foreach (IMB imb in imbs)
        {
            imb.Update();
        }
    }
}
