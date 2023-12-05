using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMusic : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] AudioSource introSong;
    [SerializeField] AudioSource loopSong;
    private bool introFinished = false;

    void Start()
    {
        loopSong.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (!introSong.isPlaying && !introFinished)
        {
            introFinished = true;
            loopSong.Play();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Milkyway");
        }
    }
}
