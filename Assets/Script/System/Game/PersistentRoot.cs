using UnityEngine;

/// <summary>
/// �S�ẴV�[���Ŏq�I�u�W�F�N�g���d�����Ȃ��悤�ɂ���X�N���v�g
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
