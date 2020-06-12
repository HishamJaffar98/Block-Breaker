using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnFx : MonoBehaviour
{
    [SerializeField] AudioSource buttonAudio;
    [SerializeField] AudioClip hoverFx;
    [SerializeField] AudioClip clickFx;

    public void SoundOnHover()
    {
        buttonAudio.PlayOneShot(hoverFx);
    }

    public void SoundOnClick()
    {
        buttonAudio.PlayOneShot(clickFx);
    }

}
