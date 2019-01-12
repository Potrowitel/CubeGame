using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public ManagerScript gameManager;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
