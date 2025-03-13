using UnityEngine;

public class ControlerBall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject, 3f);
        Debug.Log($"Objeto {collision} colidiu com o {collision.gameObject}.");
    }
}
