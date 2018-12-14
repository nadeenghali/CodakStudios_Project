using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleSpeechVolume : MonoBehaviour {
    public float volume;
    public GameObject[] speechSources;

    // Use this for initialization
    void Start()
    {
        volume = AudioCanvas.music;

        speechSources = GameObject.FindGameObjectsWithTag("Speech");
        foreach (GameObject speechSource in speechSources)
        {
            speechSource.GetComponent<AudioSource>().volume = volume;
        }
    }

    // Update is called once per frame
    void Update()
    {
        volume = AudioCanvas.music;
        foreach (GameObject speechSource in speechSources)
        {
            speechSource.GetComponent<AudioSource>().volume = volume;
        }
    }
}
