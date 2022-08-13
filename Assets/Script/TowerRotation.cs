using UnityEngine;
using NTC.Global.Cache;
public class TowerRotation : NightCache , INightFixedRun, INightInit
{
    internal float rSpeed = 150;

    public void Init()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void FixedRun()
    {
        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxisRaw("Mouse X");
            transform.Rotate(0, mouseX * rSpeed * Time.deltaTime, 0);
        }
    }
}
