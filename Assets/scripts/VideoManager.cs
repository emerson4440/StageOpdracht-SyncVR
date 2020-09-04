using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    private VideoPlayer videoPLayer;

    void Start()
    {
        videoPLayer = GetComponent<VideoPlayer>();
    }

    public void Play()
    {
        videoPLayer.Play();
    }

    public void Pause()
    {
        videoPLayer.Pause();
    }

    public void Stop()
    {
        videoPLayer.Stop();
    }

}
