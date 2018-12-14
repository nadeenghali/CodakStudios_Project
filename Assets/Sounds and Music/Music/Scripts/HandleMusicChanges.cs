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

    public static bool inBossLevel;
    public bool prevInBossLevel;

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
         else if (sceneName == "GameScene")
         {
            slowPacedMusic.Stop();
            walkingMusic.Play();
            fastPacedMusic.Stop();
        }
 
	}
	
	// Update is called once per frame
	void Update () {
        paused = PauseScript.paused;
        //inBossLevel = BossScript.inBossLevel;

        if (prevPaused!=paused && paused)
        {
            slowPacedMusic.Play();
            walkingMusic.Stop();
            fastPacedMusic.Stop();
        }
        else if (prevPaused != paused && !paused)
        {
            slowPacedMusic.Stop();
            if (inBossLevel)
            {
                walkingMusic.Stop();
                fastPacedMusic.Play();
            }
            else
            {
                walkingMusic.Play();
                fastPacedMusic.Stop();
            }
        }
        else if (prevInBossLevel != inBossLevel && inBossLevel)
        {
            slowPacedMusic.Stop();
            walkingMusic.Stop();
            fastPacedMusic.Play();
        }
        else if (prevInBossLevel != inBossLevel && !inBossLevel)
        {
            slowPacedMusic.Stop();
            walkingMusic.Play();
            fastPacedMusic.Stop();
        }
        prevPaused = paused;
        prevInBossLevel = inBossLevel;
    }
}
