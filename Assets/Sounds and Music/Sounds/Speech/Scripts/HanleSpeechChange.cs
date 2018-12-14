using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanleSpeechChange : MonoBehaviour {
    public AudioSource speechEnemyDetectsKratos1;

    public static AudioSource speechEnemyDetectsKratos;

    void Start()
    {
        speechEnemyDetectsKratos = speechEnemyDetectsKratos1;
    }

    public static void  startSpeechEnemyDetectsKratos()
    {
        speechEnemyDetectsKratos.Play();
    }
    public static void stopSpeechEnemyDetectsKratos()
    {
        speechEnemyDetectsKratos.Stop();
    }
}
