
using UnityEngine;

public class CloudSpriteSetup : MonoBehaviour
{
    public Texture2D cloudSpritesheet;

    private ParticleSystem ps;
    private ParticleSystem.Particle[] particles;
    private Sprite[] sprites;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        sprites = Resources.LoadAll<Sprite>("noBG_clouds");

        particles = new ParticleSystem.Particle[ps.main.maxParticles];

        Debug.Log("Loaded " + sprites.Length + " cloud sprites.");
    }

    void LateUpdate()
    {
        if (sprites == null || sprites.Length == 0)
            return;

        int count = ps.particleCount;

        if (particles.Length < count)
            particles = new ParticleSystem.Particle[count];

        count = ps.GetParticles(particles);

        for (int i = 0; i < count; i++)
        {
            // ParticleSystem particles cannot directly store
            // individual Sprite references here.
            // Random sprite selection needs a different renderer setup.
        }

        ps.SetParticles(particles, count);
    }
}
