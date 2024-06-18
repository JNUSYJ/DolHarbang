using UnityEngine;

public class AutoUpgrade : UpgradeController
{
    public override bool Check()
    {
        if (gameData.Won >= gameData.AutoUpgradeCost)
        {
            if (gameData.AutoUpgradeCount >= gameData.AutoUpgradeMaxCount - 1)
            {
                gameObject.SetActive(false);
            }
            return true;
        }
        return false;
    }

    public override void Upgrade()
    {
        if (Check())
        {
            gameData.Won -= gameData.AutoUpgradeCost;
            gameData.AutoIntervalTime *= gameData.AutoIntervalTimeDelta;
            gameData.AutoUpgradeCost += gameData.AutoUpgradeCostDelta;
            gameData.AutoUpgradeCount++;
            GameManager.Instance.UpdateUI();
        }
        else
        {
            // TODO : 실패 문구 OR 소리 띄우기
        }
    }
}
