using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InTheBowl : MonoBehaviour {

    public ParticleSystem peeSystem;

    public List<ParticleSystem.Particle> enter = new List<ParticleSystem.Particle>();

    void Start()
    {
        peeSystem = GetComponent<ParticleSystem>();
    }

	void OnParticleTrigger()
    {
        int particleNumber = peeSystem.GetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);

        for (int i = 0; i < particleNumber; i++)
        {
            //ParticleSystem.Particle drop = enter[i];
            //drop.startColor = new Color32(255,0,0,255);
            //enter[i] = drop;
        }

        peeSystem.SetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
    }
}
