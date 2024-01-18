using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunController : MonoBehaviour
{
    public Planet sun;

    // Start is called before the first frame update
    void Start()
    {
        sun = this.GetComponent<Planet>();
        sun.GeneratePlanet();
    }

    // Update is called once per frame
    void Update()
    {
        sun.Shape.Settings.noiseLayers[0].noiseSettings.simpleNoiseSettings.centre.x += 0.1f * Time.deltaTime;
        sun.Shape.Settings.noiseLayers[0].noiseSettings.simpleNoiseSettings.centre.y += 0.05f * Time.deltaTime;
        sun.Shape.Settings.noiseLayers[0].noiseSettings.simpleNoiseSettings.centre.z += 0.05f * Time.deltaTime;

        sun.GeneratePlanet();
    }
}
