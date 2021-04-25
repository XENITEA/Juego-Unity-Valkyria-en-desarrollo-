using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager staticGameManager;

    public AudioSource theMusic;
    public bool startPlaying;
    public BeatController theBC;

    private void Awake()
    {
        staticGameManager = this;
    }
    void Start()
    {
        //scoreText.text = "Score: 0";
        //currentMultiplier = 1;
    }
    void Update()
    {
        if(!startPlaying)
        {
            if(Input.anyKeyDown)
            {
                startPlaying = true;
                theBC.hasStarted = true;

                theMusic.Play();
            }
        }


    }
}
