using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
	//Function that allows the any scene to load through string name
	public void LoadScene(string name)
	{
		SceneManager.LoadScene(name);
	}

}
