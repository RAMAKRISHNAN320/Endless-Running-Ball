using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] float Speed = 10f;
    [SerializeField] Text scoreBoard;
    [SerializeField] AudioClip coinSound;
    [SerializeField] AudioClip DeathSound;
    [SerializeField] GameObject panel;
    int Score=0;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Vector3.right * Speed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(collision.gameObject);
            //Destroy(gameObject);
            GetComponent<PlayerInput>().enabled = false;
            panel.gameObject.SetActive(true);
            audioSource.PlayOneShot(DeathSound);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Points"))
        {
            Destroy(other.gameObject);
            Score++;
            scoreBoard.text = "Score:" + Score;
            audioSource.PlayOneShot(coinSound);
        }
    }
}
