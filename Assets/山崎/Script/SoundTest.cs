using UnityEngine;
using System.Collections;

public class SoundTest : MonoBehaviour
{
    private AudioSource[] sources;
    void Start()
    {
        sources = gameObject.GetComponents<AudioSource>();
    }


    void Update()
    {
        if (clear.Sound)
        {
            sources[1].Stop();
            sources[0].Play();

            clear.Sound=false;
        }
       
    }
}
