using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class TouchDolHarbang : MonoBehaviour
{
    public event Action ClickEvent;

    public void OnClick(InputValue value)
    {
        if (value.isPressed)
        {
            if (IsDolHarbang())
            {
                ClickEvent.Invoke();
            }
        }
    }

    public bool IsDolHarbang()
    {
        Vector2 mPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mPos, Vector2.zero);

        if (hit.collider != null)
        {
            if (hit.collider.gameObject == gameObject) return true;
        }
        return false;
    }
}
