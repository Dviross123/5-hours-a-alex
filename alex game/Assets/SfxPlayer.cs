using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxPlayer : MonoBehaviour
{
    [SerializeField] AudioSource src;
    [SerializeField] AudioClip[] alexVoiceLinesArr;

    [SerializeField] int minWaitTime = 40;
    [SerializeField] int maxWaitTime = 60;

    private void Start()
    {
        StartCoroutine(PLayRandomSfx());
    }
    private IEnumerator PLayRandomSfx()
    {
        yield return new WaitForSeconds(Random.Range(minWaitTime,maxWaitTime));
        src.PlayOneShot(alexVoiceLinesArr[Random.Range(0, alexVoiceLinesArr.Length)]);
        StartCoroutine(PLayRandomSfx());
    }
}
