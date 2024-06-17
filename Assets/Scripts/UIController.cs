using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI touchedNumText;
    [SerializeField] private TextMeshProUGUI wonNumText;
    [SerializeField] private TextMeshProUGUI auto;
    [SerializeField] private TextMeshProUGUI wonPerClickText;
    [SerializeField] private TextMeshProUGUI clickUpgradeCostText;
    [SerializeField] private TextMeshProUGUI autoUpgradeCostText;

    public void UpdateUI()
    {
        touchedNumText.text = GameManager.Instance.gameData.Touched.ToString();
        wonNumText.text = GameManager.Instance.gameData.Won.ToString();
        auto.text = GameManager.Instance.gameData.Auto ? "ON" : "OFF";
        wonPerClickText.text = GameManager.Instance.gameData.WonPerClick.ToString();
        clickUpgradeCostText.text = GameManager.Instance.gameData.ClickUpgradeCost.ToString();
        autoUpgradeCostText.text = GameManager.Instance.gameData.AutoUpgradeCost.ToString();
    }
}
