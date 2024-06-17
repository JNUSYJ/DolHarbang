public class ClickUpgrade : UpgradeController
{
    public override bool Check()
    {
        if (gameData.Won >= gameData.ClickUpgradeCost) return true;
        return false;
    }

    public override void Upgrade()
    {
        if (Check())
        {
            gameData.Won -= gameData.ClickUpgradeCost;
            gameData.WonPerClick += gameData.WonPerClickDelta;
            gameData.ClickUpgradeCost += gameData.ClickUpgradeCostDelta;
            GameManager.Instance.UpdateUI();
        }
        else
        {
            // TODO : 실패 문구 OR 소리 띄우기
        }
    }
}
