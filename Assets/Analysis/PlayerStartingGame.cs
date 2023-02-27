using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartingGame : MonoBehaviour
{
    // Start is called before the first frame update
    RestClientMessager myMessager;
    void Start()
    {
        myMessager = GetComponent<RestClientMessager>();
        myMessager.Post("StartTime", "1", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
