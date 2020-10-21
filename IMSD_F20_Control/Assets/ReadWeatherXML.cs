using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Xml;
using UnityEngine.Networking


public class ReadWeatherXML : MonoBehaviour
{
    string key = "3372725ac0a9ee495b35bc4fb4665698"; 
    public string zip;
    string apiReturn = "";
    public GameObject snowEmitter;

    [Header("Values are written to")]
    public string snowState;
    void Start()
    {
        StartCoroutine(GetWeather());
    }

    private void Update()
    {
        if (apiReturn.Length <= 0) 
            return;
        else
        {
            if (apiReturn.IndexOf("snow") != -1) 
            {
                int pmStart = apiReturn.IndexOf("snow"); 
                int pmEnd = apiReturn.IndexOf("/snow");
                int theRightMode = apiReturn.IndexOf("mode",pmStart,pmEnd-pmStart); 
                int indexofMode = theRightMode + 3;
                snowState = apiReturn.Substring(indexofMode, 1);
                Debug.Log("returning a value");
            }
        }
        if (snowState.Contains("s"))  
            snowEmitter.SetActive(true);
    }

    IEnumerator GetWeather()
    {
        UnityWebRequest www = UnityWebRequest.
            Get("http://api.openweathermap.org/data/2.5/weather?zip=10303" + zip + "&mode=xml&APPID=" + key);
        yield return www.SendWebRequest();

        if (!www.isNetworkError && !www.isHttpError)
        {
            
            Debug.Log(www.downloadHandler.text);
            apiReturn = www.downloadHandler.text;
        }
        else
        {
            Debug.Log(www.error + " " + www); 
        }
    }
}

