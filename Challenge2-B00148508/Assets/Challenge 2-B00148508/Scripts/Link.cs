using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

	public void OpenCodeRepo()
	{
		#if !UNITY_EDITOR
		openWindow("https://github.com/MonPanitan/Unity-Challenge2");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}