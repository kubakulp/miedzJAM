﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Animacje : MonoBehaviour
{
    public GameObject logo;
    public Animator animatorLoga;

    public void LoadNewScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    public void WyswietlLogo()
    {
        logo.SetActive(true);
        animatorLoga.Play("animacjaLogo");
    }
}
