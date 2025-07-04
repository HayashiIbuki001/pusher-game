using UnityEngine;

public class ItemBase : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y <= -20f)
        {
            Destroy(gameObject);
        }
    }
}
