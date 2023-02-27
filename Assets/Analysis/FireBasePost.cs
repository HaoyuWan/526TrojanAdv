using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireBasePost : MonoBehaviour
{
    // Start is called before the first frame update

    public RestClientMessager myRestClienMessager;
    
    void Start()
    {
        myRestClienMessager = GetComponent<RestClientMessager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Post all the messages to Firebase in this one method;
    public void Post(){
        //myRestClienMessager.Post("test1", "test2", 1);

        // sending all the level time total for a user.
        myRestClienMessager.Post("Time", PlayerPrefs.GetFloat("Zone1", 0) + "", 1);
        myRestClienMessager.Post("Time", PlayerPrefs.GetFloat("Zone2", 0) + "", 2);
        myRestClienMessager.Post("Time", PlayerPrefs.GetFloat("Zone3", 0) + "", 3);
        myRestClienMessager.Post("Time", PlayerPrefs.GetFloat("Zone4", 0) + "", 4);

        myRestClienMessager.Post("Damage", PlayerPrefs.GetInt("Damage1", 0) + "", 1);
        myRestClienMessager.Post("Damage", PlayerPrefs.GetInt("Damage2", 0) + "", 2);
        myRestClienMessager.Post("Damage", PlayerPrefs.GetInt("Damage3", 0) + "", 3);
        myRestClienMessager.Post("Damage", PlayerPrefs.GetInt("Damage4", 0) + "", 4);
        
        myRestClienMessager.Post("Death", PlayerPrefs.GetInt("Death1", 0) + "", 1);
        myRestClienMessager.Post("Death", PlayerPrefs.GetInt("Death2", 0) + "", 2);
        myRestClienMessager.Post("Death", PlayerPrefs.GetInt("Death3", 0) + "", 3);
        myRestClienMessager.Post("Death", PlayerPrefs.GetInt("Death4", 0) + "", 4);

        myRestClienMessager.Post("Enemy", PlayerPrefs.GetInt("Enemy1", 0) + "", 1);
        myRestClienMessager.Post("Enemy", PlayerPrefs.GetInt("Enemy2", 0) + "", 2);
        myRestClienMessager.Post("Enemy", PlayerPrefs.GetInt("Enemy3", 0) + "", 3);
        myRestClienMessager.Post("Enemy", PlayerPrefs.GetInt("Enemy4", 0) + "", 4);

        myRestClienMessager.Post("FinishTime", "", 0);




    }
}
