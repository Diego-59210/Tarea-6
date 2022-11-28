using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundFx : MonoBehaviour
{
    public AudioSource Audio;
    public void PlayFx(AudioClip clip)
    {
        Audio.PlayOneShot(clip);
    }
}
