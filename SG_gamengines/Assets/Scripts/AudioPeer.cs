using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (AudioSource))]
public class AudioPeer : MonoBehaviour
{
    AudioSource _audioSource;
    public float[] _samples = new float[512];

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        GetSpectrumCompoenent();
    }

    void GetSpectrumCompoenent()
    {
        _audioSource.GetSpectrumData(_samples,0,FFTWindow.Blackman);
    }
}
