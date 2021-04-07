using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioMixer soundMixer, musicMixer, Mixer;
    public Slider musicSlider, soundSlider;
    Datamanager data;
    void Start()
    {
        soundMixer.SetFloat("MusicVol", PlayerData.soundLevel);
        musicMixer.SetFloat("MusicVol", PlayerData.musicLevel);
        musicSlider.normalizedValue = Mathf.Pow(10, PlayerData.musicLevel/20);
        soundSlider.normalizedValue = Mathf.Pow(10, PlayerData.soundLevel/20);
    }
    public void SetLevel(float sliderValue)
    {
        float level = Mathf.Log10(sliderValue) * 20;
        Mixer.SetFloat("MusicVol", level);
        if (Mixer.name == "Music")
        {
            Mixer.GetFloat("MusicVol", out PlayerData.musicLevel);
        }
        else if (Mixer.name == "Sound")
        {
            Mixer.GetFloat("MusicVol", out PlayerData.soundLevel);
        }
    }
}
