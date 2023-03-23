using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PianoAudioScript : MonoBehaviour
{
    [SerializeField] private AudioClip _audioClip;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private float _pitch = 0;

    public void PlayKey()
    {
        _audioSource.pitch = _pitch;
        _audioSource.PlayOneShot(_audioClip);
    }
    
}
