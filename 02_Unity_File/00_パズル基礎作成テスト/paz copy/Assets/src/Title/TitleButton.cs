using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{
  public AudioClip audio;
  AudioSource audioSource;
  void Awake(){
    audioSource = GetComponent<AudioSource>();
  }
  public void OnClickStartButton()
  {
      audioSource.PlayOneShot(audio);
      SceneManager.LoadScene("Talk");
  }
}
