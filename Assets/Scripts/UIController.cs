using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI touchedNumText;
    [SerializeField] private TextMeshProUGUI wonNumText;

    public void UpdateUI()
    {
        touchedNumText.text = GameManager.Instance.Touched.ToString();
        wonNumText.text = GameManager.Instance.Won.ToString();
    }
}
