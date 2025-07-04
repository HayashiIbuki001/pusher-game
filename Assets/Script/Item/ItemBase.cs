using UnityEngine;

public class ItemBase : MonoBehaviour
{
    public void Base()
    {
        if (transform.position.y <= -20f)
        {
            Destroy(gameObject);
        }
    }
}
