using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BirdMovement : MonoBehaviour
{
    public float flySpeed;
    public Rigidbody2D rb;
    public GameObject image;
    int Score;
    public TMP_Text scoreText;
    public TMP_Text scoreText2;
    public AudioSource deathBeat;
    public GameObject wingsAudioDes;

    void Start()
    {
        transform.position = new Vector2(-6f,1f);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, flySpeed), ForceMode2D.Impulse);
        }
        scoreText.text = Score.ToString();
        scoreText2.text = Score.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Pipe"||collision.gameObject.tag == "Ground")
        {
            Time.timeScale = 0;
            deathBeat.Play();
            Destroy(this.gameObject);
            Destroy(wingsAudioDes.gameObject);
            image.gameObject.SetActive(true);
            Destroy(scoreText.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Score")
        {
            Score++;
        }
    }
}
