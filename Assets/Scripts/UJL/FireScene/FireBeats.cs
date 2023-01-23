using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBeats : MonoBehaviour
{
    [SerializeField] private AudioSource MetronomeTick;
    [SerializeField] private float BPM;
    [SerializeField] double metronomeTime = 0d;
    [SerializeField] int curBeat;
    

    private void Start()
    {
        curBeat = 0;
        MetronomeTick.mute = true;
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            QueueNextClip();
            PlayLammyClip();
        }

        if (metronomeTime < (60d/BPM))
        {
            metronomeTime += Time.deltaTime;
        }
        else if (metronomeTime >= (60d/BPM))
        {
            metronomeTime = metronomeTime-(60d/BPM);
            curBeat++;
            MetronomeTick.Play();
        }
    }
    
    public void QueueNextClip()
    {
        if (CurrentLammyClipQueue == 2)
        {
            CurrentLammyClipQueue = 1;
        }
        else
        {
            CurrentLammyClipQueue++;
        }
    }

    [SerializeField] AudioSource lammyclip;
    [SerializeField] private int CurrentLammyClipQueue;
    [SerializeField] float startTime;
    [SerializeField] float clipLength;
    public void PlayLammyClip()
    {
        if (CurrentLammyClipQueue == 1)
        {
            startTime = 0.102f;
            clipLength = 0.477f;
            lammyclip.time = startTime;
            lammyclip.PlayScheduled(AudioSettings.dspTime);
            lammyclip.SetScheduledEndTime(AudioSettings.dspTime + clipLength);
        }
        else if (CurrentLammyClipQueue == 2)
        {
            startTime = 0.657f;
            clipLength = 0.561f;
            lammyclip.time = startTime;
            lammyclip.PlayScheduled(AudioSettings.dspTime);
            lammyclip.SetScheduledEndTime(AudioSettings.dspTime + clipLength);
        }
        else { return; }
    }

    public void BeginMetronome()
    {
        MetronomeTick.mute = false;
        curBeat = 0;
        metronomeTime = 0f;
        MetronomeTick.Play();
    }
    public void EndMetronome()
    {
        MetronomeTick.mute = true;
    }
}
