using UnityEngine;
using UnityEngine.UI;

public class HelixJump : MonoBehaviour
{
    [SerializeField] private Rigidbody ballRB;
    [SerializeField] private float force = 6;

    [SerializeField] private int score = 0;
    [SerializeField] private Text lable, lable2, lable3;

    [SerializeField] private GameObject panel, panel2;
    [SerializeField] internal TowerRotation sTower;

    void OnCollisionEnter(Collision collision)
    {
        ballRB.velocity = new Vector3(ballRB.velocity.x, force, ballRB.velocity.z);

        if (collision.gameObject.tag == "PlatformD")
        {
            panel.SetActive(true);
            force = 0;
            sTower.rSpeed = 0;
            Cursor.lockState = CursorLockMode.None;
        }

        if (collision.gameObject.tag == "Finish")
        {
            panel2.SetActive(true);
            force = 0;
            sTower.rSpeed = 0;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    void Update()
    {
        lable.text = score.ToString();
        lable2.text = score.ToString();
        lable3.text = score.ToString();
    }

    public void OnTriggerEnter(Collider other)
    {
        score += 1;
    }
}
