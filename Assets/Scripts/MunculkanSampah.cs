using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculkanSampah : MonoBehaviour
{
    public float jeda = 0.8f;
    float timer;

    public GameObject[] objekSampah;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > jeda)
        {
            int random = Random.Range(0, objekSampah.Length);
            Instantiate(objekSampah[random], transform.position, Quaternion.identity);
            timer = 0f;
        }

        TingkatLevel.instance.KenaikanLevel();
    }
}
