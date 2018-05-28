using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterList : MonoBehaviour
{
    public List<Encounter> Encounters { get; set; }

	// Use this for initialization
	void Start ()
	{
	    Encounters = new List<Encounter>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
