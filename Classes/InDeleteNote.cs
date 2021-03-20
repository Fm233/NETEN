using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
public class InDeleteNote : MonoBehaviour
{
    public Action<ModelInDeleteNoteToUseDeleteNote> modelInDeleteNoteToUseDeleteNoteAction { get; set; }
    float jukeTime = 0f;

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // TODO Add delete key
        if (Touch.activeTouches.Count >= 3)
        {
            modelInDeleteNoteToUseDeleteNoteAction(new ModelInDeleteNoteToUseDeleteNote(jukeTime));
        }
    }

    public void ReceiveModelOutJukeTime(ModelOutJukeTime modelOutJukeTime)
    {
        jukeTime = modelOutJukeTime.time;
    }
    
}
