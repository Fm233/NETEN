using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
public class InJukeMove : MonoBehaviour
{
    public Slider slider;
    public Action<ModelInJukeMoveToOutJukebox> modelInJukeMoveToOutJukeboxAction { get; set; }

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void OnSliderMove()
    {
        modelInJukeMoveToOutJukeboxAction(new ModelInJukeMoveToOutJukebox(slider.value));
    }
}
