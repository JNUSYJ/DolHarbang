using UnityEngine;

public abstract class UpgradeController : MonoBehaviour
{
    protected GameData gameData;

    public void Start()
    {
        gameData = GameManager.Instance.gameData;
    }

    public abstract bool Check();
    public abstract void Upgrade();
}
