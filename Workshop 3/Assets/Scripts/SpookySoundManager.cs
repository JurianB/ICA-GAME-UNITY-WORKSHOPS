using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpookySoundManager : MonoBehaviour
{
    public AudioSource Source;

    [Range(0, 1)]
    public float MinVolume;

    [Range(0, 1)]
    public float MaxVolume;

    private GameObject[] _enemies;

    // Start is called before the first frame update
    void Start()
    {
        _enemies = GameObject.FindGameObjectsWithTag("Enemy");

        Source.volume = MinVolume;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
