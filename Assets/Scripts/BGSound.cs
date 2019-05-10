﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSound : MonoBehaviour {

    private static BGSound instance = null;
    public static BGSound Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }
}
