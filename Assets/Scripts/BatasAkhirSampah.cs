using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BatasAkhirSampah : MonoBehaviour
{
    public string sceneOver;

    public AudioClip failedClip;
    public AudioSource failedAudio;
    // Start is called before the first frame update
    void Start()
    {
        failedAudio = gameObject.AddComponent<AudioSource>();
        failedAudio.clip = failedClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        SceneManager.LoadScene(sceneOver);
        failedAudio.Play();
    }
}
