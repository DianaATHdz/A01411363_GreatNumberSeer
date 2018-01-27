﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Seer : MonoBehaviour
{
    private int min;
    private int max;
    private int guess;

    [SerializeField] int attempts;
    [SerializeField] Text guessLabel;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        min = 1;
        max = 501;
        guess = UnityEngine.Random.Range(min, max);
        ShowGuess();
    }

    private void NextGuess()
    {
        if (attempts == 0)
        {
            SceneManager.LoadScene("Lose");
        }
        guess = UnityEngine.Random.Range(min, max);
        attempts--;
        ShowGuess();
    }

    private void ShowGuess()
    {
        guessLabel.text = "Is your number " + guess + "?";
    }

    public void isHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void isLower()
    {
        max = guess;
        NextGuess();
    }

    public void Correct()
    {
        SceneManager.LoadScene("Win");
    }

    // Update is called once per frame
    void Update()
    {

    }
}