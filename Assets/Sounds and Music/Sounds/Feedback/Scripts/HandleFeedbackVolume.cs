using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleFeedbackVolume : MonoBehaviour {
    public float volume;
    public GameObject[] feedbackSources;

    // Use this for initialization
    void Start()
    {
        volume = AudioCanvas.music;

        feedbackSources = GameObject.FindGameObjectsWithTag("Feedback");
        foreach (GameObject feedbackSource in feedbackSources)
        {
            feedbackSource.GetComponent<AudioSource>().volume = volume;
        }
    }

    // Update is called once per frame
    void Update()
    {
        volume = AudioCanvas.music;
        foreach (GameObject speechSource in feedbackSources)
        {
            speechSource.GetComponent<AudioSource>().volume = volume;
        }
    }
}
