using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : MonoBehaviour {
    [SerializeField] float timeUntilNextLevel = 5;
    float timer;
    LevelManager levelManager;

	// Use this for initialization
	void Start () {
        levelManager = GetComponent<LevelManager>();
        timer = timeUntilNextLevel;
	}
	
	// Update is called once per frame
	void Update () {
        Timer();
	}

    void Timer()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            levelManager.LoadLevel("Start");
        }
    }
}
