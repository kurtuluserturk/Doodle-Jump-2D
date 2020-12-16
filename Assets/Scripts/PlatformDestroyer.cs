using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformDestroyer : MonoBehaviour
{
    public AudioClip gameOverClip;
    AudioSource audioSource;
    byte levelRestartTime = 1;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag=="Platform")
        {
            Destroy(col.gameObject);
        }    
        else
        {
            StartCoroutine(RestartLevel());
        }
    }      
    IEnumerator RestartLevel()
    {
        audioSource.PlayOneShot(gameOverClip);
        yield return new WaitForSeconds(levelRestartTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
