using UnityEngine;

public class ParticlesController : MonoBehaviour
{
    public ParticleSystem particleEffect; // Arraste o sistema de part�culas no Inspector

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Ativa ao pressionar a tecla Espa�o
        {
            particleEffect.Play();
        }
    }
}