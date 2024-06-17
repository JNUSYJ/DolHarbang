using System;
using UnityEngine;

[Serializable]
public class GameData
{
    [Header("Score")]
    public int Won;
    public int Touched;
    public bool Auto;

    [Header("Setting")]
    public int WonPerClick;
    public float AutoClickIntervalTime;

    [Header("Upgrade")]
    public int ClickUpgradeCost;
    public int AutoUpgradeCost;

    public GameData()
    {
        Won = 0;
        Touched = 0;
        Auto = false;
        WonPerClick = 100;
        AutoClickIntervalTime = 5f;
        ClickUpgradeCost = 500;
        AutoUpgradeCost = 1000;
    }
}
