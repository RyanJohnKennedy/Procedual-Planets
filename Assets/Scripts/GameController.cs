using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Planet[] planets;
    public GameObject[] planetsGO;
    // Start is called before the first frame update
    void Start()
    {
        planetsGO = GameObject.FindGameObjectsWithTag("Planet");
        planets = new Planet[planetsGO.Length];

        for (int i = 0; i < planetsGO.Length; i++)
        {
            planets[i] = planetsGO[i].GetComponent<Planet>();
        }

        InizialisePlanets();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InizialisePlanets()
    {
        foreach (Planet p in planets)
        {
            p.GeneratePlanet();
        }
    }
}
