using UnityEngine;
using System.Collections;
using Galaxia;

public class SineDistributor : ParticleDistributor {

    public float Spread = 100;
    public float Height = 10;

    public override void Process(ProcessContext context)
    {
        //here we assign the position of the particles
        //a random Z coordinate
        float randomZ = UnityEngine.Random.value;
        //a percentage of the position in the particle array
        float posPer = (float)context.particle.index / (float)context.particles.Count;
        //the height based on the sine of X and Z
        float height = Height * Mathf.Sin(Mathf.PI * 2 * posPer) * Mathf.Cos(Mathf.PI * 2 * randomZ);
        context.particle.position = new Vector3(posPer, height, randomZ) * Spread * context.galaxy.Size;

        //this is a builtin function to automaticly assign colors, size and rotation
        //depending on the Particle Prefab properties
        ProcessProperties(context, context.particle.position,0);
    }
}
