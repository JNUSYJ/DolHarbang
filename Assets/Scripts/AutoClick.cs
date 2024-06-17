using System.Collections;
using UnityEngine;

public class AutoClick : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(AutoClickCoroutine());
    }

    private IEnumerator AutoClickCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(GameManager.Instance.gameData.AutoClickIntervalTime);
            GameManager.Instance.dolHarbang.GetComponent<ClickDolHarbang>().InvokeDolHarbangClickEvent();
        }
    }
}
