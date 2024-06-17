using UnityEngine;

public class AnimationEffect : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    private void Start()
    {
        GameManager.Instance.dolHarbang.GetComponent<ClickDolHarbang>().DolHarbangClickEvent += PlayTapAnimation;
    }

    private void PlayTapAnimation()
    {
        animator.Play("TapAnimation", -1, 0f);
    }
}
