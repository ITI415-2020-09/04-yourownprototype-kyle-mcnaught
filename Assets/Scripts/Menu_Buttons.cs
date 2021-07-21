using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Buttons : MonoBehaviour
{
    public void LoadGame()
    	{
    		SceneManager.LoadScene("Scene_0");
    	}

		public void LoadControls()
    	{
    		SceneManager.LoadScene("How_to_Play");
    	}

		public void LoadMain()
    	{
    		SceneManager.LoadScene("Main_Menu");
    	}
}
