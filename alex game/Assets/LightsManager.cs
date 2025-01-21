using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsManager : MonoBehaviour
{
    [SerializeField] Light[] lightsArr;
    [SerializeField] int minFlickerTimes;
    [SerializeField] int maxFlickerTimes;
    [SerializeField] float flickerSpeed;


    [SerializeField] float NormalIntensity;
    [SerializeField] int lowIntensity;


    [SerializeField] float minEventCD;
    [SerializeField] int maxEventCD;
    void Start()
    {
       StartCoroutine(FlickerLight());
    }

    IEnumerator FlickerLight()
    {
        //random lights
        int times = Random.Range(minFlickerTimes, maxFlickerTimes);
        for (int i = 0; i < times; i++) 
        {
            yield return new WaitForSeconds(flickerSpeed);
            if (lightsArr[0].intensity == NormalIntensity) 
            { 
                for(int j =0; j<lightsArr.Length; j+= 2)
                {
                    lightsArr[j].intensity = lowIntensity;
                }
            }

            else if (lightsArr[0].intensity == lowIntensity)
            {
                for (int j = 0; j < lightsArr.Length; j += 2)
                {
                    lightsArr[j].intensity = NormalIntensity;
                }
            }
        }

        yield return new WaitForSeconds(Random.Range(minEventCD, maxEventCD));

        StartCoroutine(FlickerLight());
    }

}
