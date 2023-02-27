using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKilled : MonoBehaviour
{
    // Start is called before the first frame update
    public string levelEnemy;

    private int times;

    void Start()
    {
         times = 0;
    }


    public void takeDeath(){
        times = times + 1;
    }

    void OnDestroy(){
        times = times + PlayerPrefs.GetInt(levelEnemy, 0);
        Debug.Log("EnemyKilled in zone " + levelEnemy + ": " + times );
        PlayerPrefs.SetInt(levelEnemy, times);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
