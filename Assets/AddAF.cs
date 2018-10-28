using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddAF : MonoBehaviour {
    public static GameObject obj = null;
    public string ANDROID_PACKAGE_NAME_HERE;
    // Use this for initialization
    void Start()
    {
        if (obj == null)
        {
            obj = this.gameObject;
            DontDestroyOnLoad(this.gameObject);

            /* Mandatory - set your AppsFlyer’s Developer key. */
            AppsFlyer.setAppsFlyerKey("GQCQdRAEjrJcXTfZHVtw77");
            /* For detailed logging */
            /* AppsFlyer.setIsDebug (true); */
            #if UNITY_IOS
            /* Mandatory - set your apple app ID
            NOTE: You should enter the number only and not the "ID" prefix */
            AppsFlyer.setAppID ("YOUR_APP_ID_HERE");
            AppsFlyer.trackAppLaunch ();
            #elif UNITY_ANDROID
            /* Mandatory - set your Android package name */
            AppsFlyer.setAppID(ANDROID_PACKAGE_NAME_HERE);
            /* For getting the conversion data in Android, you need to add the "AppsFlyerTrackerCallbacks" listener.*/
            AppsFlyer.init("GQCQdRAEjrJcXTfZHVtw77", "AppsFlyerTrackerCallbacks");
            #endif
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
