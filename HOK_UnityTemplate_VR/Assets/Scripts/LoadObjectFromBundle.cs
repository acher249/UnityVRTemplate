using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadObjectFromBundle : MonoBehaviour
{
    
	void Start ()
	{
	    StartCoroutine("DownloadObject");
	}

    IEnumerator DownloadObject()
    {
        //Now instead of getting from local directory get it from server
        WWW www = WWW.LoadFromCacheOrDownload("file:///" + Application.dataPath + "/AssetBundles/room", 1);
        //WWW www = WWW.LoadFromCacheOrDownload();
        yield return www;

        AssetBundle bundle = www.assetBundle;

        //I have a DemoScene Prefab inside my already created "room" AssetBundle then do stuff..
        AssetBundleRequest request = bundle.LoadAssetAsync<GameObject>("DemoScene");

        yield return request;

        GameObject DemoScene = request.asset as GameObject;
        Instantiate<GameObject>(DemoScene);
    }
}
