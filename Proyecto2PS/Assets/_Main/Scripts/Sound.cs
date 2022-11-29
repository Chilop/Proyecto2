using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    [SerializeField] private AudioClip _audioclip;
    [SerializeField] private string _songName;

    [Range(0f, 1f)]
    [SerializeField] private float _volume;
    [Range(.1f, 3f)]
    [SerializeField] private float _pitch;
}
