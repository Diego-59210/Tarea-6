﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelTaller : MonoBehaviour
{
    [LevelSelector(false)]
    public string levelToLoad;
    
    public void LoadLevelNowText()
    {
        Debug.Log("Load level [" + levelToLoad + "]");
    }

    public void LoadLevelNow()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void SetLevelToLoad(string newLevel)
    {
        levelToLoad = newLevel;
    }
}

internal class LevelSelectorAttribute : Attribute
{
    private bool v;

    public LevelSelectorAttribute(bool v)
    {
        this.v = v;
    }
}