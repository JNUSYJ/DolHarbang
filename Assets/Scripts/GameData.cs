using System;
using UnityEngine;

[Serializable]
public class GameData
{
    [Header("Score")]
    public int Won;
    public int Touched;

    [Header("Setting")]
    public bool Auto;
    public int WonPerClick;
    public int WonPerClickDelta;
    public float AutoIntervalTime;
    public float AutoIntervalTimeDelta;

    [Header("Upgrade")]
    public int ClickUpgradeCost;
    public int ClickUpgradeCostDelta;
    public int AutoBuyCost;
    public int AutoUpgradeCost;
    public int AutoUpgradeCostDelta;
    public int AutoUpgradeCount;
    public int AutoUpgradeMaxCount;

    /*
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
    */
}
