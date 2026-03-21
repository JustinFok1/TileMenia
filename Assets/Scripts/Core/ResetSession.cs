using UnityEngine;

public class ResetSession : MonoBehaviour
{
    void Awake()
    {
        if (GameSession.Instance != null)
        {
            Destroy(GameSession.Instance.gameObject);
        }
    }
}