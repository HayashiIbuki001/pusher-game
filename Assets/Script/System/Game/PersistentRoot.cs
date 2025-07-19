using UnityEngine;

/// <summary>
/// 全てのシーンで子オブジェクトが重複しないようにするスクリプト
/// </summary>
public class PersistentRoot : MonoBehaviour
{
    private static PersistentRoot instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
