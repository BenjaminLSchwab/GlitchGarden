using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

    public AudioClip[] LevelMusicChangeArray;
    AudioSource audioSource;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnLevelWasLoaded(int level)
    {
        Debug.Log(level);
        if (!LevelMusicChangeArray[level]) return;
        audioSource.clip = LevelMusicChangeArray[level];
        audioSource.Play();
    }
}
