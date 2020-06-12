﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audiomixer;
 public void SetVolume (float volume)
    {
        audiomixer.SetFloat("volume", volume);
    }
}