using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutCardCtrl : MonoBehaviour
{
    public Action<ModelGetInsSongCard> modelGetInsSongCardAction { get; set; }

    public Action<ModelGetInsLevelCard> modelGetInsLevelCardAction { get; set; }

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
        // Judge if active
        bool active = false;
        if (menuState == MenuState.MENU)
        {
            active = true;
        }

        // Set cards
        modelGetInsLevelCardAction(new ModelGetInsLevelCard((InsLevelCard card) =>
        {
            return true;
        }, (List<InsLevelCard> list) =>
        {
            foreach (InsLevelCard card in list)
            {
                card.gameObject.SetActive(active);
            }
        }));
        modelGetInsSongCardAction(new ModelGetInsSongCard((InsSongCard card) =>
        {
            return true;
        }, (List<InsSongCard> list) =>
        {
            foreach (InsSongCard card in list)
            {
                card.gameObject.SetActive(active);
            }
        }));
    }
    
}
