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
       Debug.Log(MetalBandNameGenerator.Generate("Kain's Key", 1, 1));
       Debug.Log(MetalBandNameGenerator.Generate("Death Riddles Explained", 1, 1));
       Debug.Log(MetalBandNameGenerator.Generate("Destructor Of Innards", 1, 1));
       Debug.Log(MetalBandNameGenerator.Generate("Gorewolf", 1, 1)); 


       Debug.Log(MetalBandNameGenerator.Generate("Mesmerising Miasma", 0.1f, 0.1f));
       Debug.Log(MetalBandNameGenerator.Generate("Heavy Death", 0.5f, 0.5f)); 
       Debug.Log(MetalBandNameGenerator.Generate("Clones Of War", 0.8f, 0.8f)); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
