using UnityEngine;

public class TowerRotation : MonoBehaviour
{
    public float rSpeed = 150;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {

        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxisRaw("Mouse X");
            transform.Rotate(0, mouseX * rSpeed * Time.deltaTime, 0);
        }

    }
}
