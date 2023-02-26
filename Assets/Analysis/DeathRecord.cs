using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathRecord : MonoBehaviour
{
    public string levelDeath;

    private int times;
    // Start is called before the first frame update
    void Start()
    {
        times = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDeath(){
        times = times + 1;
    }

    void OnDestroy(){
        times = times + PlayerPrefs.GetInt(levelDeath, 0);
        Debug.Log("Death in zone " + levelDeath + ": " + times );
        PlayerPrefs.SetInt(levelDeath, times);
    }

}