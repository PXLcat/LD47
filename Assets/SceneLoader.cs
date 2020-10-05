﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private string[] gameScenesNames = default;

    private void Awake()
    {
        SceneManager.LoadScene(gameScenesNames[0], LoadSceneMode.Additive);

    }
}
