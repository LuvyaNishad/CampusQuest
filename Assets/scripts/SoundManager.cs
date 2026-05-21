using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [Header("Audio Sources")]
    public AudioSource musicSource;
    public AudioSource sfxSource;
    public AudioSource walkSource;

    [Header("Audio Clips")]
    public AudioClip clickSound;
    public AudioClip teleportSound;
    public AudioClip xpSound;
    public AudioClip chestOpenSound;
    public AudioClip chestCloseSound;
    public AudioClip walkSound;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    void Start()
    {
        if (musicSource != null && musicSource.clip != null)
        {
            musicSource.loop = true;
            musicSource.Play();
        }
    }

    public void PlayClick()
    {
        if (sfxSource != null && clickSound != null)
            sfxSource.PlayOneShot(clickSound);
    }

    public void PlayTeleport()
    {
        if (sfxSource != null && teleportSound != null)
            sfxSource.PlayOneShot(teleportSound);
    }

    public void PlayXP()
    {
        if (sfxSource != null && xpSound != null)
            sfxSource.PlayOneShot(xpSound);
    }

    public void PlayChestOpen()
    {
        if (sfxSource != null && chestOpenSound != null)
            sfxSource.PlayOneShot(chestOpenSound);
    }

    public void PlayChestClose()
    {
        if (sfxSource != null && chestCloseSound != null)
            sfxSource.PlayOneShot(chestCloseSound);
    }

    public void StartWalk()
    {
        if (walkSource != null && walkSound != null)
        {
            if (!walkSource.isPlaying)
            {
                walkSource.clip = walkSound;
                walkSource.loop = true;
                walkSource.Play();
            }
        }
    }

    public void StopWalk()
    {
        if (walkSource != null && walkSource.isPlaying)
        {
            walkSource.Stop();
        }
    }
}