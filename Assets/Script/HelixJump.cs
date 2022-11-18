using UnityEngine;
using UnityEngine.UI;
using NTC.Global.Cache;

public class HelixJump : NightCache, INightFixedRun
{
    [Header("Отскок игрока")]
    [SerializeField] private Rigidbody ballRB;
    [SerializeField] private float force = 6;
    [Header("Очки игрока")]
    [SerializeField] private int score = 0;
    [SerializeField] private Text lable, lable2, lable3;
    [Header("Панели")]
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject panel2;
    [Header("Звуки игрока")]
    [SerializeField] private AudioClip _audio;
    [SerializeField] private AudioClip _audioScore;
    [SerializeField] private AudioClip _audioD;
    [SerializeField] private AudioClip _audioV;
    [SerializeField] private new AudioSource audio;
    [Header("Уровень")]
    [SerializeField] internal TowerRotation sTower;

    void OnCollisionEnter(Collision collision)
    {
        
        ballRB.velocity = new Vector3(ballRB.velocity.x, force, ballRB.velocity.z);
        audio.PlayOneShot(_audio);

        if (collision.gameObject.CompareTag("PlatformD"))
        {
            audio.PlayOneShot(_audioD);
            panel.SetActive(true);
            ballRB.velocity = Vector3.zero;
            force = 0;
            sTower.rSpeed = 0;
            Cursor.lockState = CursorLockMode.None;
        }
       

        if (collision.gameObject.CompareTag("Finish"))
        {
            panel2.SetActive(true);
            force = 0;
            sTower.rSpeed = 0;
            Cursor.lockState = CursorLockMode.None;
            ballRB.velocity = Vector3.zero;
            audio.PlayOneShot(_audioV);
        }
    }

    public void FixedRun()
    {
        lable.text = score.ToString();
        lable2.text = score.ToString();
        lable3.text = score.ToString();
    }

    public void OnTriggerEnter(Collider other)
    {
        score += 1;
        audio.PlayOneShot(_audioScore);
    }

}
