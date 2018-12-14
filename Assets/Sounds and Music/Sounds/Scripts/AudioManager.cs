using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public AudioSource effectKratosWalking;
    public AudioSource effectEnemyWalking;

    public AudioSource feedbackKratosHit;
    public AudioSource feedbackKratosDied;
    public AudioSource feedbackEnemyHit;
    public AudioSource feedbackEnemyDied;
    public AudioSource feedbackKratosCollect;
    public AudioSource feedbackKratosRage;

    //Kratos effect
    public void startKratosWalking()
    {
        effectKratosWalking.Play();
    }
    public void stopKratosWalking()
    {
        effectKratosWalking.Stop();
    }
    //kratos feedback
    public void playKratosIsHit()
    {
        feedbackKratosHit.Play();
    }
    public void stopKratosIsHit()
    {
        feedbackKratosHit.Stop();
    }
    public void playKratosDies()
    {
        feedbackKratosDied.Play();
    }
    public void stopKratosDies()
    {
        feedbackKratosDied.Stop();
    }
    public void playKratosCollectsHealth()
    {
        feedbackKratosCollect.Play();
    }
    public void stopKratosCollectsHealth()
    {
        feedbackKratosCollect.Stop();
    }
    public void playKratosRage()
    {
        feedbackKratosRage.Play();
    }
    public void stopKratosRage()
    {
        feedbackKratosRage.Stop();
    }

    //enemy effect
    public void startEnemyWalking()
    {
        effectEnemyWalking.Play();
    }
    public void stopEnemyWalking()
    {
        effectEnemyWalking.Stop();
    }
    //enemy feedback
    public void playEnemyIsHit()
    {
        feedbackEnemyHit.Play();
    }
    public void stopEnemyIsHit()
    {
        feedbackEnemyHit.Stop();
    }
    public void playEnemyDies()
    {
        feedbackEnemyDied.Play();
    }
    public void stopEnemyDies()
    {
        feedbackEnemyDied.Stop();
    }
}
