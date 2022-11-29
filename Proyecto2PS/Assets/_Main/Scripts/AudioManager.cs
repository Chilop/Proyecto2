using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioSource _MainMenu;
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
    public void PlaySound(AudioClip audioClip)
    {
        _MainMenu.PlayOneShot(audioClip);
    }

    public void ShootPlayer()
    {

    }

    public void AmbientMusic()
    {

    }

    public void PlayMainTheme()
    {

    }
}
