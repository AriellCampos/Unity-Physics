using UnityEngine;

public class CannonControl : MonoBehaviour
{
    public float rotationSpeed = 5f; // Velocidade de rota��o do canh�o
    public float minAngle = -10f;    // �ngulo m�nimo de inclina��o
    public float maxAngle = 45f;     // �ngulo m�ximo de inclina��o

    private float currentAngle; // Guarda o �ngulo atual

    void Start()
    {
        // Inicializa o �ngulo com base na rota��o inicial do canh�o
        currentAngle = transform.localEulerAngles.x;
        if (currentAngle > 180) currentAngle -= 360; // Ajusta caso esteja acima de 180
    }

    void Update()
    {
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");

        if (scrollInput != 0)
        {
            currentAngle -= scrollInput * rotationSpeed; // Ajusta o �ngulo
            currentAngle = Mathf.Clamp(currentAngle, minAngle, maxAngle); // Limita o �ngulo

            transform.localRotation = Quaternion.Euler(currentAngle, 0, 0); // Aplica a rota��o apenas no eixo X

            Debug.Log($"Canh�o inclinado para {currentAngle} graus"); // Log para depura��o
        }
    }
}