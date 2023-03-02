using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Models;
using Proyecto26;
using UnityEngine.Networking;

public class RestClientMessager : MonoBehaviour
{

    private readonly string basePath = "https://datacollection-54f60-default-rtdb.firebaseio.com";
	private RequestHelper currentRequest;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Post(string title, string body, int levelNum){
		Debug.Log("Sending: " + title + " body " + body + " lelve " + levelNum);
		// We can add default query string params for all requests
		RestClient.DefaultRequestParams["param1"] = "My first param";
		RestClient.DefaultRequestParams["param3"] = "My other param";

		currentRequest = new RequestHelper {
			Uri = basePath + "/posts.json",
			Params = new Dictionary<string, string> {
				{ "param1", "value 1" },
				{ "param2", "value 2" },
				{ "param3", "value 3" }
			},
			Body = new Post {
				title = title,
				body = body,
				level = levelNum,
				userId = 1
			},
			EnableDebug = true
		};
		RestClient.Post<Post>(currentRequest)
		.Then(res => {

			// And later we can clear the default query string params for all requests
			RestClient.ClearDefaultParams();

			//this.LogMessage("Success", JsonUtility.ToJson(res, true));
		})
		.Catch(err => Debug.Log("Error + err.Message"));
	}


}
