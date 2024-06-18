using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClickDolHarbang : MonoBehaviour
{
    // 클릭 시 발생할 이벤트
    // 재화 증가, 애니메이션, 파티클, 사운드 효과 등이 등록됨
    public event Action DolHarbangClickEvent;

    // 마우스 왼쪽버튼 클릭 입력 시 InputAction에서 호출되는 메서드
    // 돌하르방이 클릭되었는지 체크하고 이벤트 호출
    public void OnClick(InputValue value)
    {
        if (value.isPressed)
        {
            if (IsDolHarbang())
            {
                InvokeDolHarbangClickEvent();
            }
        }
    }

    // 이벤트 호출하는 메서드
    public void InvokeDolHarbangClickEvent()
    {
        DolHarbangClickEvent?.Invoke();
    }

    // 돌하르방이 클릭되었는지 체크하는 메서드
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
