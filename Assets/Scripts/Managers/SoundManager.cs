using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Manager
{

    public AudioSource firstMusicSource,dosMusicSource;
    public AudioSource sfxSource;
    public AudioClip fastClip;
    private bool mainMusicPlaying = true;
    public void LaunchSfx(AudioClip sfx)
    {
        sfxSource.clip = sfx;
        sfxSource.Play();
    }

    public void LaunchMusic(AudioClip music)
    {
        firstMusicSource.Pause();
        dosMusicSource.clip = music;
        dosMusicSource.Play();
        mainMusicPlaying = false;
    }

    public void ContinueMusic()
    {
        dosMusicSource.Stop();
        mainMusicPlaying = true;
        firstMusicSource.Play();
    }

    public void ChangeSongByTime()
    {
        firstMusicSource.clip = fastClip;
        if(mainMusicPlaying ) 
        {
            firstMusicSource.Play();
        }
    }
    
}
