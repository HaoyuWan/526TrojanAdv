using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageLevel : MonoBehaviour
{
    public string levelDamage;

    private int damageNum;
    // Start is called before the first frame update
    void Start()
    {
        damageNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(int num){
        damageNum = damageNum + num;
    }

    void OnDestroy(){
        damageNum = damageNum + PlayerPrefs.GetInt(levelDamage, 0);
        Debug.Log("Damage in zone " + levelDamage + ": " + damageNum);
        PlayerPrefs.SetInt(levelDamage, damageNum);
    }

}
