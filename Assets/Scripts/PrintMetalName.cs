using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintMetalName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

       Debug.Log(MetalBandNameGenerator.Generate("Boomer", 1, 1));
       Debug.Log(MetalBandNameGenerator.Generate("Alberto Vermicelli", 1, 1));
       Debug.Log(MetalBandNameGenerator.Generate("Kain's key", 1, 1));
       Debug.Log(MetalBandNameGenerator.Generate("Death Riddles Explained", 1, 1));
       Debug.Log(MetalBandNameGenerator.Generate("Destructor of innards", 1, 1));
       Debug.Log(MetalBandNameGenerator.Generate("Gorewolf", 1, 1)); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
