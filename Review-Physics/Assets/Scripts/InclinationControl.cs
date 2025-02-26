using UnityEngine;

public class InclinationControl : MonoBehaviour
{
    [SerializeField] private float _inclinationSpeed = 5f;

    private void Update()
    {
        float horizontal = -Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward, 
            horizontal * Time.deltaTime * _inclinationSpeed);
    }
}
