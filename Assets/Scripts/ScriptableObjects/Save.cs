﻿using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Save : ScriptableObject
{
    #region Public Members

    public List<float> defaultFillAmounts = new List<float>() { .5f, .5f, .5f, .5f };

    public List<float> fillAmounts = new List<float>();

    public Perso currentPerso;
    public Questions currentQuestion;

    public List<Perso> persos = new List<Perso>();

    #endregion

    #region Public void

    #endregion

    #region System

    #endregion

    #region Class Methods

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion
}
