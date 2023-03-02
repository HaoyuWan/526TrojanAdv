using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearPlayerPrefs : MonoBehaviour
{
    private static bool hasClearedPlayerPrefs = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake()
    {
        if (!hasClearedPlayerPrefs)
        {
            PlayerPrefs.DeleteAll();
            hasClearedPlayerPrefs = true;
        }
    }
}
