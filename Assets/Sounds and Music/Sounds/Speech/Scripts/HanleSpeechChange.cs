using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanleSpeechChange : MonoBehaviour {
    public static AudioSource speechEnemyDetectsKratos;
    
    public static void  startSpeechEnemyDetectsKratos()
    {
        speechEnemyDetectsKratos.Play();
    }
    public static void stopSpeechEnemyDetectsKratos()
    {
        speechEnemyDetectsKratos.Stop();
    }
}
