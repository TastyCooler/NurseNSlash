using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer instance = null;

    private void Awake()
    {
        Singleton();
    }

    /// <summary>
    /// restricts the instantiation of a class to one object; I only need one Music Player!
    /// </summary>
    void Singleton()
    {
        //Debug.Log("Music player Awake " + GetInstanceID());
        if (instance != null)
        {
            Destroy(gameObject);
            print("Duplicate music player self-destructing!");
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
}
