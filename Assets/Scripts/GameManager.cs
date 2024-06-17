using System.Collections;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject dolHarbang;
    public UIController UI;

    public int WonPlusAmount = 100;
    public float AutoClickIntervalTime = 5f;

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
        dolHarbang.GetComponent<ClickDolHarbang>().DolHarbangClickEvent += AddScore;
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
}
