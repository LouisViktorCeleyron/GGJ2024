using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource musicSource;
    public AudioSource sfxSource;

    public void LaunchSfx(AudioClip sfx)
    {
        sfxSource.clip = sfx;
        sfxSource.Play();
    }

    public void LaunchMusic(AudioClip music)
    {
        sfxSource.clip = music;
        sfxSource.Play();
    }
}
