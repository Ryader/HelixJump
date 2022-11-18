using UnityEngine;

public class BoomPlatform : MonoBehaviour
{
    [SerializeField] private new GameObject gameObject;

    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

}
