using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGetting : MonoBehaviour
{

    public string levelKey;
    // Start is called before the first frame update
    RestClientMessager myMessager;
    void Start()
    {
        myMessager = GetComponent<RestClientMessager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Post(){
        myMessager.Post("Key", levelKey, 0);
    }

}
