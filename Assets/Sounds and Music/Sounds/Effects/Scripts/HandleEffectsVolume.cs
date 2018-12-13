using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleEffectsVolume : MonoBehaviour {
    public float volume;
    public GameObject[] effectsSources;

    // Use this for initialization
    void Start()
    {
        volume = AudioCanvas.music;

        effectsSources = GameObject.FindGameObjectsWithTag("Effect");
        foreach (GameObject effectsSource in effectsSources)
        {
            effectsSource.GetComponent<AudioSource>().volume = volume;
        }
    }

    // Update is called once per frame
    void Update()
    {
        volume = AudioCanvas.music;
        foreach (GameObject speechSource in effectsSources)
        {
            speechSource.GetComponent<AudioSource>().volume = volume;
        }
    }
}
