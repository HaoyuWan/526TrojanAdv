using System;
 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

public class Count : MonoBehaviour
{
    
     public KeyCode currentKey;
     public Event e;
     public float Space=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
         {
             Debug.LogError("Update,LeftShift");
         }
         else if (Input.GetKeyDown(KeyCode.RightShift))
         {
             Debug.LogError("Update,RightShift");
         }
     }
      void OnGUI()
     {
         //if (Input.anyKeyDown)
         //{
         //    e = Event.KeyboardEvent;
         //    if (e.isKey)
         //    {
         //        currentKey = e.keyCode;
         //        Debug.LogError("Current Key is : " + currentKey.ToString());
         //    }
         //}
 //循环遍历输出
         if (Input.anyKeyDown)
         {
            //  foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
            //  {
                 if (Input.GetKeyDown(KeyCode.Space))
                 {
                    Space++;
                     Debug.LogError("Current Key is : space, count: "+(int)(Space/4) );
                 }
                 
            //  }
         }
     }
}
