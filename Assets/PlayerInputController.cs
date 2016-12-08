using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour {
	private enum ControllerKind {
		VoiceRecognition,
		ArrowKeys
	};

	private static ControllerKind kind = ControllerKind.VoiceRecognition;
	private static VoiceRecognition recognition = new VoiceRecognition();

	public static Vector2 TranslateMove()
	{
		if (kind == ControllerKind.ArrowKeys)
			return ArrowsMove ();
		else {
			return recognition.VoiceMove ();
		}
	}

	private static Vector2 ArrowsMove()
	{
		Vector2 input = Vector2.zero;

		return input;
	}
}
