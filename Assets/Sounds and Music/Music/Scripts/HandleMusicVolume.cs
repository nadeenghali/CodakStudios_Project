using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleMusicVolume : MonoBehaviour {
    public float volume;
    public GameObject[] musicSources;

    // Use this for initialization
    void Start () {
        volume = AudioCanvas.music;

        musicSources = GameObject.FindGameObjectsWithTag("Music");
        foreach (GameObject musicSource in musicSources)
        {
            musicSource.GetComponent<AudioSource>().volume = volume;
        }
    }
	
	// Update is called once per frame
	void Update () {
        volume = AudioCanvas.music;
        foreach (GameObject musicSource in musicSources)
        {
            musicSource.GetComponent<AudioSource>().volume = volume;
        }
    }
}
