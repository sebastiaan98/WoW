﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSaving : MonoBehaviour {

	void Start () {
		if (!PlayerPrefs.HasKey ("HairType")) 
		{
			PlayerPrefs.SetInt ("HairType",0);
		}
		if(!PlayerPrefs.HasKey ("HairColor"))
		{
			PlayerPrefs.SetInt ("HairColor",0);
		}
	}

	public void SetHairType(int key)
	{
		PlayerPrefs.SetInt ("HairType",key);
	}
	public void SetHairColor(int key)
	{
		PlayerPrefs.SetInt ("HairColor",key);
	}
}
