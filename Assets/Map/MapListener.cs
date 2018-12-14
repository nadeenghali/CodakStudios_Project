using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapListener : MonoBehaviour {
    
    public  GameObject LevelOneWaveOne;
    public  GameObject LevelOneWaveTwo;
    public  GameObject LevelOneWaveTwo_2;

    public GameObject LevelTwoWaveOne;
    public GameObject LevelTwoWaveTwo;

    public  GameObject LevelOne;
    public  GameObject LevelTwo;

    public  GameObject EnemyOne;
    public  GameObject EnemyTwo;
    public  GameObject EnemyThree;
    public  GameObject EnemyFour;

    private static int EnemiesKilled = 0;
    private static bool LogicUpdate = false;

    public static bool EnemiesCreate = false;
    public static int level = 1;
    public static int wave = 1;

    // Use this for initialization
    void Start () {
        EnemiesCreate = true;
        CallEnemies();
    }
	
	// Update is called once per frame
	void Update () {
        KeyboardButtons();
        LevelLogic();
        CallEnemies();
    }

    void KeyboardButtons()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            LevelOneWaveOne.transform.Rotate(0.0f,90f,0.0f);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            LevelOneWaveTwo.transform.Rotate(0.0f, 90f, 0.0f);
            LevelOneWaveTwo_2.transform.Rotate(0.0f, 90f, 0.0f);

        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            LevelOne.transform.Rotate(0.0f, 90f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            LevelTwoWaveOne.transform.Rotate(0.0f, 90f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            LevelTwoWaveTwo.transform.Rotate(0.0f, 90f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            LevelTwo.transform.Rotate(0.0f, 90f, 0.0f);
        }
    }

    

    void CallEnemies()
    {
        if (!EnemiesCreate)
            return;
        switch (level)
        {
            case 1:
                {
                    switch (wave)
                    {
                        case 1:
                            //Instantiate(EnemyThree, new Vector3(5.0f, 2.0f, 37.0f), Quaternion.identity);
                            Instantiate(EnemyOne, new Vector3(5.0f, 2.0f, 37.0f), Quaternion.identity);
                            Instantiate(EnemyTwo, new Vector3(4.0f, 2.0f, 42.0f), Quaternion.identity);
                            break;
                        case 2:
                            Instantiate(EnemyTwo, new Vector3(-11.0f, 1.8f, 10.0f), Quaternion.identity);
                            Instantiate(EnemyTwo, new Vector3(-11.0f, 1.8f, 25.0f), Quaternion.identity);                            break;
                        case 3:
                            Instantiate(EnemyThree, new Vector3(-3.0f, -9.7f, 34.0f), Quaternion.identity);
                            Instantiate(EnemyThree, new Vector3(-26.0f, -9.7f, 47.0f), Quaternion.identity);
                            break;
                    }
                }
                break;
            case 2:
                {
                    switch (wave)
                    {
                        case 1:
                            Instantiate(EnemyThree, new Vector3(-14.0f, -9.7f, 69.0f), Quaternion.identity);
                            Instantiate(EnemyThree, new Vector3(-0.15f, -9.7f, 77.0f), Quaternion.identity);
                            break;
                        case 2:
                            Instantiate(EnemyFour, new Vector3(32.0f, 2.5f, 135.0f), Quaternion.identity);
                            Instantiate(EnemyFour, new Vector3(32.0f, 2.5f, 114.0f), Quaternion.identity);
                            break;
                        case 3:
                            Instantiate(EnemyThree, new Vector3(48.0f, 2.5f, 118.0f), Quaternion.identity);
                            Instantiate(EnemyFour, new Vector3(49.0f, 2.5f, 128.0f), Quaternion.identity);
                            break;
                    }
                }
                break;
            case 3:
                LevelTwo.transform.Rotate(0.0f, -90f, 0.0f);
                break;
        }
        wave++;
        if (wave == 4)
        {
            level++;
            wave = 1;
        }
        EnemiesCreate = false;
    }



    void LevelLogic()
    {
        if (!LogicUpdate)
        {
            switch (EnemiesKilled)
            {
                case 2: //Invoke("CallEnemies", SpawnDelay); 
                        LevelOneWaveOne.transform.Rotate(0.0f, 90f, 0.0f); break;
                case 4: //Invoke("CallEnemies", SpawnDelay); 
                        LevelOneWaveTwo.transform.Rotate(0.0f, 90f, 0.0f); LevelOneWaveTwo_2.transform.Rotate(0.0f, 90f, 0.0f); break;
                case 6: //Invoke("CallEnemies", SpawnDelay); 
                        LevelOne.transform.Rotate(0.0f, 90f, 0.0f); break;
                case 8: //Invoke("CallEnemies", SpawnDelay); 
                        LevelTwoWaveOne.transform.Rotate(0.0f, 90f, 0.0f); break;
                case 10: //Invoke("CallEnemies", SpawnDelay); 
                        LevelTwoWaveTwo.transform.Rotate(0.0f, 90f, 0.0f); break;
                case 12: LevelTwo.transform.Rotate(0.0f, 90f, 0.0f); break;
            }
            LogicUpdate = true;
        }
    }

    public static void KillEnemy()
    {
        EnemiesKilled++;
        LogicUpdate = false;
    }
}
