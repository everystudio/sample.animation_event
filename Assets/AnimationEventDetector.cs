using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

[Serializable]
public class UnityEventString : UnityEvent<string> { }

public class AnimationEventDetector : MonoBehaviour
{
	public UnityEventString OnAnimationEventString = new UnityEventString();
	public void OnAnimationEvent(string _strMessage)
	{
		Debug.Log($"AnimationEventDetector:{_strMessage}");
		OnAnimationEventString.Invoke(_strMessage);
	}
}
