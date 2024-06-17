using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject dolHarbang;
    [SerializeField] private UIController UI;

    [SerializeField] private int WonPlusAmount = 100;

    public int Touched { get; private set; } = 0;
    public int Won { get; private set; } = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        dolHarbang.GetComponent<TouchDolHarbang>().ClickEvent += AddScore;
    }

    public void AddScore()
    {
        Touched++;
        Won += WonPlusAmount;
        UpdateUI();
    }

    public void UpdateUI()
    {
        UI.UpdateUI();
    }

    public void SetWonPlusAmount(int amount)
    {
        WonPlusAmount = amount;
    }
}
