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

    private void Start()
    {
        
    }
    public void AmbientMusic(AudioClip levelMusic)
    {
        _audioSourceMusic.PlayOneShot(levelMusic);
    }

    public void ShootPlayer()
    {
        PlaySound(_gunSound);
    }

    public void PlaySound(AudioClip gunSound)
    {
        _audioSourceSFX.PlayOneShot(gunSound);
    }

    public void PlayMainTheme(AudioClip mainMusic)
    {
        _audioSourceMusic.PlayOneShot(mainMusic);
    }
}
