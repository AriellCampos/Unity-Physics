using UnityEngine;

public class CannonControl : MonoBehaviour
{
    public float rotationSpeed = 5f; // Velocidade de rotação do canhão
    public float minAngle = -10f;    // Ângulo mínimo de inclinação
    public float maxAngle = 45f;     // Ângulo máximo de inclinação

    private float currentAngle; // Guarda o ângulo atual

    void Start()
    {
        // Inicializa o ângulo com base na rotação inicial do canhão
        currentAngle = transform.localEulerAngles.x;
        if (currentAngle > 180) currentAngle -= 360; // Ajusta caso esteja acima de 180
    }

    void Update()
    {
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");

        if (scrollInput != 0)
        {
            currentAngle -= scrollInput * rotationSpeed; // Ajusta o ângulo
            currentAngle = Mathf.Clamp(currentAngle, minAngle, maxAngle); // Limita o ângulo

            transform.localRotation = Quaternion.Euler(currentAngle, 0, 0); // Aplica a rotação apenas no eixo X

            Debug.Log($"Canhão inclinado para {currentAngle} graus"); // Log para depuração
        }
    }
}