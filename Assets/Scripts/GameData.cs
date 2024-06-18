using System;
using UnityEngine;

[Serializable]
public class GameData
{
    [Header("Score")]
    public int Won;                     // 재화
    public int Touched;                 // 클릭 횟수

    [Header("Setting")]
    public bool Auto;                   // 자동클릭 활성여부
    public int WonPerClick;             // 클릭당 재화획득량
    public int WonPerClickDelta;        // 강화 시 재화획득량 증가치
    public float AutoIntervalTime;      // 자동클릭 대기시간
    public float AutoIntervalTimeDelta; // 강화 시 자동클릭 대기시간 감소치(곱연산)

    [Header("Upgrade")]
    public int ClickUpgradeCost;        // 클릭 업그레이드 비용
    public int ClickUpgradeCostDelta;   // 클릭 업그레이드 비용 증가치
    public int AutoBuyCost;             // 자동클릭 활성화 비용
    public int AutoUpgradeCost;         // 자동클릭 업그레이드 비용
    public int AutoUpgradeCostDelta;    // 자동클릭 업그레이드 비용 증가치
    public int AutoUpgradeCount;        // 자동클릭 업그레이드 횟수
    public int AutoUpgradeMaxCount;     // 자동클릭 업그레이드 최대 횟수

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
