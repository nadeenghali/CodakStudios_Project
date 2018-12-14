using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanleSpeechChange : MonoBehaviour {
    public AudioSource speechEnemyDetectsKratos;
    
    public void startSpeechEnemyDetectsKratos()
    {
        speechEnemyDetectsKratos.Play();
    }
    public void stopSpeechEnemyDetectsKratos()
    {
        speechEnemyDetectsKratos.Stop();
    }
}
