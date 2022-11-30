using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }
    [SerializeField] private AudioSource _audioSourceSFX;
    [SerializeField] private AudioSource _audioSourceMusic;
    [SerializeField] private AudioClip _MainTheme;
    [SerializeField] private AudioClip _gunSound;
    [SerializeField] private AudioClip _musicBackgorund;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void AmbientMusic(AudioClip levelMusic)
    {
        _audioSourceMusic.PlayOneShot(levelMusic);
    }

    public void PlayAmbientMusic()
    {
        AmbientMusic(_musicBackgorund);
    }

    public void ShootPlayer()
    {
        PlaySoundShoot(_gunSound);
    }

    public void PlaySoundShoot(AudioClip gunSound)
    {
        _audioSourceSFX.PlayOneShot(gunSound);
    }

    public void PlayMainTheme(AudioClip mainMusic)
    {
        _audioSourceMusic.PlayOneShot(mainMusic);
    }

    public void MusicMainTheme()
    {
        PlayMainTheme(_MainTheme);
    }
}
