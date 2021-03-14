using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.EnhancedTouch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
public class InCreateNote : MonoBehaviour
{
    public Action<Note> noteAction { get; set; }
    float jukeTime = 0f;

    public void Start()
    {
        // Start here
        EnhancedTouchSupport.Enable();
    }
    public void Update()
    {
        Touch.onFingerDown += Tap;
    }

    void Tap(Finger finger)
    {
        // TODO Support 3+
        if (Touch.activeTouches.Count == 2)
        {
            Vector2[] reals = new Vector2[2];
            for (int i = 0; i < 2; i++)
            {
                Touch touch = Touch.activeTouches[i];
                reals[i] = TouchToGamePos(touch.screenPosition);
            }

            // Return note
            noteAction(new Note(reals, GenerateCloudFromReals(reals), jukeTime));
        }
    }

    Vector2 TouchToGamePos(Vector2 pos)
    {
        return Camera.main.ScreenToWorldPoint(pos + Vector2.up * 80);
    }

    Vector2[] GenerateCloudFromReals(Vector2[] reals)
    {
        // TODO Support 3+
        Vector2 a = reals[0];
        Vector2 b = reals[1];
        Vector2 mid = (a + b) / 2;
        Vector2 normalizedDelta = (a - b).normalized;
        List<Vector2> result = new List<Vector2>();
        for (int i = -5; i < 6; i++)
        {
            float mul = i * 0.2f + 0.1f * UnityEngine.Random.Range(-1f, 1f);
            result.Add(mid + normalizedDelta * mul);
        }
        return result.ToArray();
    }

    public void ReceiveModelOutJukeTime(ModelOutJukeTime modelOutJukeTime)
    {
        jukeTime = modelOutJukeTime.time;
    }


    
    
    
    
    
    
    
    
}
