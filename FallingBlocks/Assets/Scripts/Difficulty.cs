using UnityEngine;
using System.Collections;

public static class Difficulty {											//static class makes the entire class and its methods avaiable to other classes

	static float secondsToMaxDifficulty = 60;								//the amount of time in seconds until the game reaches its hardest mode

	public static float GetDifficultyPercent(){								//static method allows other classes that use the static class access to the method
		return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxDifficulty);			//clamp returns a value between 0 and 1
	}


}