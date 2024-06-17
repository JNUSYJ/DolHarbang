using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    [SerializeField] private AudioClip stoneSound;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        GameManager.Instance.dolHarbang.GetComponent<ClickDolHarbang>().DolHarbangClickEvent += PlayStoneSound;
    }

    private void PlayStoneSound()
    {
        audioSource.PlayOneShot(stoneSound);
    }
}
