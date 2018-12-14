using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanleSpeechChange : MonoBehaviour {
    public AudioSource speechEnemyDetectsKratos;
    public static bool enemyDetectsKratos;
    public bool prevEnemyDetectsKratos;

    public void  startSpeechEnemyDetectsKratos()
    {
        //enemyDetectsKratos = EnemyOne.enemyDetectsKratos || EnemyTwo.enemyDetectsKratos || EnemyThree.enemyDetectsKratos || EnemyFour.enemyDetectsKratos;
        if (prevEnemyDetectsKratos != enemyDetectsKratos && enemyDetectsKratos)
            speechEnemyDetectsKratos.Play();
        //prev
    }
    public void stopSpeechEnemyDetectsKratos()
    {
        //enemyDetectsKratos = EnemyOne.enemyDetectsKratos || EnemyTwo.enemyDetectsKratos || EnemyThree.enemyDetectsKratos || EnemyFour.enemyDetectsKratos;
        if (prevEnemyDetectsKratos != enemyDetectsKratos && !enemyDetectsKratos)
            speechEnemyDetectsKratos.Stop();
    }
}
