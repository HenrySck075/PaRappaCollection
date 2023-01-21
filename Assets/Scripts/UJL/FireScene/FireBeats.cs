using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBeats : MonoBehaviour
{
    [SerializeField] private AudioSource MetronomeTick;
    [SerializeField] private float BPM;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            QueueNextClip();
            PlayLammyClip();
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
}
