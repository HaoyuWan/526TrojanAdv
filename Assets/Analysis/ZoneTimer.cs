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
       timeSpent = PlayerPrefs.GetFloat(zoneName, 0.0f);
       Debug.Log("test: " + PlayerPrefs.GetFloat(zoneName, 0.0f));
       Debug.Log("startTime" + ": "+ startTime.ToString("F2") + " seconds " + "timeSpent : " + timeSpent.ToString("F2") + "seconds.");
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
