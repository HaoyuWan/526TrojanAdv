//using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class ZoneTimer : MonoBehaviour
{
    public string zoneName;

    private float startTime;

    private float timeSpent;

    void Start()
    {
       startTime = Time.time;
       timeSpent = PlayerPrefs.GetFloat(zoneName, 0);
    }

    void Update()
    {

    }

    void OnDestroy()
    {
        float time = Time.time - startTime + timeSpent;
        Debug.Log("Time in zone " + zoneName + ": " + time.ToString("F2") + " seconds");
        PlayerPrefs.SetFloat(zoneName, time);
    }
}
