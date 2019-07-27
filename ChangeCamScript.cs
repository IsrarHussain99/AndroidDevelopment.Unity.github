using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamScript : MonoBehaviour {

public GUISkin theSkin;
	public int a = 226;
	public int b = 11;
	public int c = 238;
	public int d = 32;


int CamNumber;
public Smoothfoll[] CamScripts;
	// Use this for initialization
	void Start () {
		CamNumber = PlayerPrefs.GetInt("CamNo", 1);
		CamChange();
	}

	void CamChange()
	{

		foreach(Smoothfoll obj in CamScripts)
		{
			obj.enabled = false;
			CamScripts[CamNumber].enabled = true;

		}
		PlayerPrefs.SetInt("CamNo", CamNumber);
	}


	void OnGUI()
	{
		GUI.skin = theSkin;
	  GUI.skin.GetStyle("CamIcon");

		if (GUI.Button(new Rect(a, b, c, d), "", "CamIcon"))
		{
			if (CamNumber == 4)
			{
				CamNumber = 0;
				CamChange();
			}
			else {
				CamNumber++;
				CamChange();
			}
		}
	}
}
