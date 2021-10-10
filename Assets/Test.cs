using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
	[SerializeField]
	private Button m_btnRed;
	[SerializeField]
	private Button m_btnBlue;

	[SerializeField]
	private Animator m_mainImageAnimator;

	private void Start()
	{
		m_btnRed.onClick.AddListener(OnClickRed);
		m_btnBlue.onClick.AddListener(OnClickBlue);
	}

	private void SetButtonInteractable(int _iColor)
	{
		m_btnRed.interactable = 1 != _iColor;
		m_btnBlue.interactable = 2 != _iColor;
	}

	public void OnClickRed()
	{
		SetButtonInteractable(0);
		m_mainImageAnimator.SetInteger("color", 1);
	}
	public void OnClickBlue()
	{
		SetButtonInteractable(0);
		m_mainImageAnimator.SetInteger("color", 2);
	}
	public void OnAnimationEnd(string _strMessage)
	{
		Debug.Log($"Test:{_strMessage}");
		if( _strMessage == "red")
		{
			SetButtonInteractable(1);
		}
		else
		{
			SetButtonInteractable(2);
		}
	}
}
