using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour {

    MeshRenderer mate;
    AudioSource audio;
    AudioClip clip;

    int play = 0;

    public int Play
    {
        get
        {
            return play;
        }

        set
        {
            play = value;
        }
    }

    public void big()
    {
        transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        mate = GetComponent<MeshRenderer>();

        mate.material.color = new Color(180, 50, 130);


            audio.PlayOneShot(clip);
    }

    public void small()
    {
        transform.localScale = new Vector3(1, 1, 1);
        mate = GetComponent<MeshRenderer>();

        mate.material.color = new Color(255, 255, 255);
    }

    // Use this for initialization


    void Start () {
        audio = GetComponent<AudioSource>();
        clip = GetComponent<AudioClip>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
