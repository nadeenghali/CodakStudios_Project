using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public AudioSource effectKratosWalking;
    public AudioSource effectEnemyWalking;

    public static bool kratosWalking;
    public static bool enemyWalkin;
    public bool prevKratosWalking;
    public bool prevEnemyWalkin;

    public AudioSource feedbackKratosHit;
    public static bool kratosHit;
    public bool prevKratosHit;
    public AudioSource feedbackKratosDied;
    public static bool kratosDied;
    public bool prevKratosDied;
    public AudioSource feedbackEnemyHit;
    public static bool enemyHit;
    public bool prevEnemyHit;
    public AudioSource feedbackEnemyDied;
    public static bool enemyDied;
    public bool prevEnemyDied;
    public AudioSource feedbackKratosCollect;
    public static bool kratosCollect;
    public bool prevKratosCollect;
    public AudioSource feedbackKratosRage;
    public static bool kratosRage;
    public bool prevKratosRage;

    //Kratos effect
    public void startKratosWalking()
    {
        if (prevKratosWalking != kratosWalking && kratosWalking)
            effectKratosWalking.Play();
    }
    public void stopKratosWalking()
    {
        if (prevKratosWalking != kratosWalking && !kratosWalking)
            effectKratosWalking.Stop();
    }
    //kratos feedback
    public void playKratosIsHit()
    {
        if (prevKratosHit != kratosHit && kratosHit)
            feedbackKratosHit.Play();
    }
    public void stopKratosIsHit()
    {
        if (prevKratosHit != kratosHit && !kratosHit)
            feedbackKratosHit.Stop();
    }
    public void playKratosDies()
    {
        if (prevKratosDied != kratosDied && kratosDied)
            feedbackKratosDied.Play();
    }
    public void stopKratosDies()
    {
        if (prevKratosDied != kratosDied && !kratosDied)
            feedbackKratosDied.Stop();
    }
    public void playKratosCollectsHealth()
    {
        if (prevKratosCollect != kratosCollect && kratosCollect)
            feedbackKratosCollect.Play();
    }
    public void stopKratosCollectsHealth()
    {
        if (prevKratosCollect != kratosCollect && !kratosCollect)
            feedbackKratosCollect.Stop();
    }
    public void playKratosRage()
    {
        if (prevKratosRage != kratosRage && kratosRage)
            feedbackKratosRage.Play();
    }
    public void stopKratosRage()
    {
        if (prevKratosRage != kratosRage && !kratosRage)
            feedbackKratosRage.Stop();
    }

    //enemy effect
    public void startEnemyWalking()
    {
        if (prevEnemyWalkin != enemyWalkin && enemyWalkin)
            effectEnemyWalking.Play();
    }
    public void stopEnemyWalking()
    {
        if (prevEnemyWalkin != enemyWalkin && !enemyWalkin)
            effectEnemyWalking.Stop();
    }
    //enemy feedback
    public void playEnemyIsHit()
    {
        if (prevEnemyHit != enemyHit && enemyHit)
            feedbackEnemyHit.Play();
    }
    public void stopEnemyIsHit()
    {
        if (prevEnemyHit != enemyHit && !enemyHit)
            feedbackEnemyHit.Stop();
    }
    public void playEnemyDies()
    {
        if (prevEnemyDied != enemyDied && enemyDied)
            feedbackEnemyDied.Play();
    }
    public void stopEnemyDies()
    {
        if (prevEnemyDied != enemyDied && !enemyDied)
            feedbackEnemyDied.Stop();
    }
}
