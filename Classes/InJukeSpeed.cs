using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
public class InJukeSpeed : MonoBehaviour
{
    public Slider slider;
    public Action<ModelInJukeSpeedToOutJukebox> modelInJukeSpeedToOutJukeboxAction { get; set; }

    public void Start()
    {
        // Start here
    }
    public void Update()
    {
        // Update here
    }

    public void OnSliderChange()
    {
        modelInJukeSpeedToOutJukeboxAction(new ModelInJukeSpeedToOutJukebox(slider.value));
    }
}
