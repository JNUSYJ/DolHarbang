using System.Collections;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject dolHarbang;
    public UIController UI;
    public ParticleSystem DolHarbangParticleSystem;

    public GameData gameData;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        DolHarbangParticleSystem = GameObject.FindGameObjectWithTag("Particle").GetComponent<ParticleSystem>();

        // gameData = new GameData();
    }

    private void Start()
    {
        dolHarbang.GetComponent<ClickDolHarbang>().DolHarbangClickEvent += AddScore;

        UpdateUI();
    }

    public void AddScore()
    {
        gameData.Touched++;
        gameData.Won += gameData.WonPerClick;
        UpdateUI();
    }

    public void UpdateUI()
    {
        UI.UpdateUI();
    }
}
