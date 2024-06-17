using UnityEngine;

public class ParticleEffect : MonoBehaviour
{
    private ParticleSystem dolHarbangParticleSystem;

    private void Start()
    {
        dolHarbangParticleSystem = GameManager.Instance.DolHarbangParticleSystem;
        GameManager.Instance.dolHarbang.GetComponent<ClickDolHarbang>().DolHarbangClickEvent += ShowParticleEffect;
    }

    private void ShowParticleEffect()
    {
        InitParticle();
        dolHarbangParticleSystem.Play();
    }

    private void InitParticle()
    {
        dolHarbangParticleSystem.transform.position = gameObject.transform.position;
        //ParticleSystem.EmissionModule em = dolHarbangParticleSystem.emission;
        //em.SetBurst(0, new ParticleSystem.Burst(0, 1));
        //ParticleSystem.MainModule mm = dolHarbangParticleSystem.main;
        //mm.startSpeedMultiplier = 1f;
    }
}
