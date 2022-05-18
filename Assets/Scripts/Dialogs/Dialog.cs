﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialog                     //новый клас для введения персонажей с диалогами
{
    public string name;

    [TextArea(3, 10)]
    public string[] sentences;              //масив с предложениями
}
