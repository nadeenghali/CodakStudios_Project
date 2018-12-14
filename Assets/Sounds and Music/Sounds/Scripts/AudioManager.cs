using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public AudioSource effectKratosWalking1;
    public AudioSource effectEnemyWalking1;

    public AudioSource feedbackKratosHit1;
    public AudioSource feedbackKratosDied1;
    public AudioSource feedbackEnemyHit1;
    public AudioSource feedbackEnemyDied1;
    public AudioSource feedbackKratosCollect1;
    public AudioSource feedbackKratosRage1;

    public static AudioSource effectKratosWalking;
    public static AudioSource effectEnemyWalking;

    public static AudioSource feedbackKratosHit;
    public static AudioSource feedbackKratosDied;
    public static AudioSource feedbackEnemyHit;
    public static AudioSource feedbackEnemyDied;
    public static AudioSource feedbackKratosCollect;
    public static AudioSource feedbackKratosRage;

    void start()
    {
        effectKratosWalking = effectKratosWalking1;
        effectEnemyWalking = effectEnemyWalking1;
        feedbackKratosHit = feedbackKratosHit1;
        feedbackKratosDied = feedbackKratosDied1;
        feedbackKratosCollect = feedbackKratosCollect1;
        feedbackKratosRage = feedbackKratosRage1;
        feedbackEnemyHit = feedbackEnemyHit1;
        feedbackEnemyDied = feedbackEnemyDied1;

    }
    //Kratos effect
    public static void startKratosWalking()
    {
        effectKratosWalking.Play();
    }
    public static void stopKratosWalking()
    {
        effectKratosWalking.Stop();
    }
    //kratos feedback
    public static void playKratosIsHit()
    {
        feedbackKratosHit.Play();
    }
    public static void stopKratosIsHit()
    {
        feedbackKratosHit.Stop();
    }
    public static void playKratosDies()
    {
        feedbackKratosDied.Play();
    }
    public static void stopKratosDies()
    {
        feedbackKratosDied.Stop();
    }
    public static void playKratosCollectsHealth()
    {
        feedbackKratosCollect.Play();
    }
    public static void stopKratosCollectsHealth()
    {
        feedbackKratosCollect.Stop();
    }
    public static void playKratosRage()
    {
        feedbackKratosRage.Play();
    }
    public static void stopKratosRage()
    {
        feedbackKratosRage.Stop();
    }

    //enemy effect
    public static void startEnemyWalking()
    {
        effectEnemyWalking.Play();
    }
    public static void stopEnemyWalking()
    {
        effectEnemyWalking.Stop();
    }
    //enemy feedback
    public static void playEnemyIsHit()
    {
        feedbackEnemyHit.Play();
    }
    public static void stopEnemyIsHit()
    {
        feedbackEnemyHit.Stop();
    }
    public static void playEnemyDies()
    {
        feedbackEnemyDied.Play();
    }
    public static void stopEnemyDies()
    {
        feedbackEnemyDied.Stop();
    }
}
