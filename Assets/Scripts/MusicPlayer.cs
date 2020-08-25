using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    Scene scene;
    MusicPlayer mp;
    float secondsToPause = 4f;

    //IEnumerator PauseBeforeStartingMusic()
    //{
    //    yield return new WaitForSeconds(secondsToPause);
    //    AudioSource audioSource = GetComponent<AudioSource>();
    //    audioSource.Play();

    //}

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        if (scene.name.ToString().Equals("Game"))
        {            
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.PlayDelayed(3);
        }
        else
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.PlayDelayed(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
