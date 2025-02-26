using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransferManager : MonoBehaviour
{
    public string targetSceneName = "AlternateScene"; // Nome da cena alvo
    public KeyCode transferKey = KeyCode.T; // Tecla para transferir o objeto

    void Update()
    {
        if (Input.GetKeyDown(transferKey))
        {
            MoveObjectToAnotherScene();
        }
    }

    void MoveObjectToAnotherScene()
    {
        Scene targetScene = SceneManager.GetSceneByName(targetSceneName);
        if (targetScene.IsValid())
        {
            SceneManager.MoveGameObjectToScene(gameObject, targetScene);
            Debug.Log($"Objeto {gameObject.name} movido para a cena {targetSceneName}.");
        }
        else
        {
            Debug.LogError($"Cena {targetSceneName} não encontrada!");
        }
    }
}
