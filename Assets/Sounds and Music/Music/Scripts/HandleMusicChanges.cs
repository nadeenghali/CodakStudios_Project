using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandleMusicChanges : MonoBehaviour {
    public AudioSource slowPacedMusic;
    public AudioSource walkingMusic;
    public AudioSource fastPacedMusic;
    public static bool paused;
    public bool prevPaused;

	// Use this for initialization
	void Start () {
		// Create a temporary reference to the current scene.
         Scene currentScene = SceneManager.GetActiveScene ();
         prevPaused = PauseScript.paused;
         paused = PauseScript.paused;
        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "MainMenuScene") 
         {
            slowPacedMusic.Play();
            walkingMusic.Stop();
            fastPacedMusic.Stop();
         }
         else if (sceneName == "Level1Scene" || sceneName == "Level2Scene")
         {
            slowPacedMusic.Stop();
            walkingMusic.Play();
            fastPacedMusic.Stop();
        }
 
	}
	
	// Update is called once per frame
	void Update () {
        paused = PauseScript.paused;
        if (prevPaused!=paused && paused)
        {
            slowPacedMusic.Play();
            walkingMusic.Stop();
            fastPacedMusic.Stop();
        }
        else if (prevPaused != paused && !paused)
        {
            slowPacedMusic.Stop();
            walkingMusic.Play();
            fastPacedMusic.Stop();
        }
        prevPaused = paused;

    }
}
