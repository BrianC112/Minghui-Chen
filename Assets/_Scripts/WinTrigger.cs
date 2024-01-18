using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public ParticleSystem winParticle;

    private bool isPlay;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!isPlay)
            {
                winParticle.Play();
                isPlay = true;
            }
        }
    }
}
