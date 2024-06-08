using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeteksiSampah : MonoBehaviour
{
    public string nameTag;
    public AudioClip audioCorrect;
    public AudioClip audioFalse;

    public AudioSource mediaPlayerCorrect;
    public AudioSource mediaPlayerFalse;
    public Text scoreText;

    [SerializeField] int scoreEnter;
    // Start is called before the first frame update
    void Start()
    {
        mediaPlayerCorrect = gameObject.AddComponent<AudioSource>();
        mediaPlayerCorrect.clip = audioCorrect;

        mediaPlayerFalse = gameObject.AddComponent<AudioSource>();
        mediaPlayerFalse.clip = audioFalse;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals(nameTag))
        {
            DataScorer.score += scoreEnter/2;
            scoreText.text = DataScorer.score.ToString();
            Destroy(collision.gameObject);
            mediaPlayerCorrect.Play();
        }
        else
        {
            DataScorer.score -= scoreEnter/2;
            scoreText.text = DataScorer.score.ToString();
            Destroy(collision.gameObject);
            mediaPlayerFalse.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
