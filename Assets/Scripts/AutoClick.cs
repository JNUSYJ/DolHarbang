using System.Collections;
using UnityEngine;

public class AutoClick : MonoBehaviour
{
    public void AutoClickActive()
    {
        if (GameManager.Instance.gameData.Auto)
        { 
            StartCoroutine(AutoClickCoroutine());
        }
    }

    private IEnumerator AutoClickCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(GameManager.Instance.gameData.AutoIntervalTime);
            GameManager.Instance.dolHarbang.GetComponent<ClickDolHarbang>().InvokeDolHarbangClickEvent();
        }
    }
}
