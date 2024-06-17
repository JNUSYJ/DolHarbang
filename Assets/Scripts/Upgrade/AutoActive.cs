using UnityEngine;

public class AutoActive : UpgradeController
{
    public GameObject autoUpgradeBtn;
    public AutoClick autoClick;

    public override bool Check()
    {
        if (gameData.Won >= gameData.AutoBuyCost) return true;
        return false;
    }

    public override void Upgrade()
    {
        if (Check())
        {
            gameData.Won -= gameData.AutoBuyCost;
            gameData.Auto = true;
            autoClick.AutoClickActive();
            autoUpgradeBtn.SetActive(true);
            gameObject.SetActive(false);
            GameManager.Instance.UpdateUI();
        }
        else
        {
            // TODO : 실패 문구 OR 소리 띄우기
        }
    }
}
