using UnityEngine;

public class PusherController : MonoBehaviour
{
    [SerializeField] float speed = 3.0f;
    [SerializeField] float distance = 10.0f;

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        transform.position = startPos + Vector3.forward * Mathf.Sin(Time.time * speed) * distance;
    }

    //private void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.tag == "Coin")
    //    {
    //        // プッシャーの子オブジェクトにする
    //        other.gameObject.transform.parent = this.transform;
    //        other.transform.SetParent(this.transform, false);
    //    }
    //}

    //private void OnCollisionExit(Collision other)
    //{
    //    if (other.gameObject.tag == "Coin")
    //    {
    //        // 親離れ
    //        other.gameObject.transform.parent = null;
    //    }
    //}
}
