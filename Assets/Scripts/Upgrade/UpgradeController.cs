using UnityEngine;

public abstract class UpgradeController : MonoBehaviour
{
    protected GameData gameData;

    public void Start()
    {
        gameData = GameManager.Instance.gameData;
    }

    public abstract bool Check();   // 업그레이드가 가능한지 체크하는 메서드
    public abstract void Upgrade(); // 업그레이드 메서드
}
