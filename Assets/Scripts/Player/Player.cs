﻿using UnityEngine;
    internal class Player : MonoBehaviour
    {
    [Header("Config")]
    [SerializeField] private PlayerStats stats;

    public PlayerStats Stats => stats;
    }

