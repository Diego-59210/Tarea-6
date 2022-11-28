using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundFX : MonoBehaviour
{
    public AudioSource audios;
    public void PlayFx(AudioClip clip)
    {
        audios.PlayOneShot(clip);
    }
}
