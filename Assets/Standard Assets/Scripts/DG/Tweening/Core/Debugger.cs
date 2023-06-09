using System;
using UnityEngine;

namespace DG.Tweening.Core
{
	public static class Debugger
	{
		public static void Log(object message)
		{
			UnityEngine.Debug.Log("DOTWEEN :: " + message);
		}

		public static void LogWarning(object message)
		{
			UnityEngine.Debug.LogWarning("DOTWEEN :: " + message);
		}

		public static void LogError(object message)
		{
			UnityEngine.Debug.LogError("DOTWEEN :: " + message);
		}

		public static void LogReport(object message)
		{
			UnityEngine.Debug.Log("<color=#00B500FF>DOTWEEN :: " + message + "</color>");
		}

		public static void LogInvalidTween(Tween t)
		{
			Debugger.LogWarning("This Tween has been killed and is now invalid");
		}

		public static void LogNestedTween(Tween t)
		{
			Debugger.LogWarning("This Tween was added to a Sequence and can't be controlled directly");
		}

		public static void LogNullTween(Tween t)
		{
			Debugger.LogWarning("Null Tween");
		}

		public static void LogNonPathTween(Tween t)
		{
			Debugger.LogWarning("This Tween is not a path tween");
		}

		public static void LogMissingMaterialProperty(string propertyName)
		{
			Debugger.LogWarning(string.Format("This material doesn't have a {0} property", propertyName));
		}

		public static void LogRemoveActiveTweenError(string propertyName)
		{
			Debugger.Log(string.Format("Error in RemoveActiveTween.{0}. It's been taken care of so no problems, but Daniele (DOTween's author) is trying to pinpoint it and it would be awesome if you could reproduce this log in a sample project and send it to him. Or even just write him the complete log that was generated by this message. Fixing this would make DOTween slightly faster. Thanks.", propertyName));
		}

		public static void SetLogPriority(LogBehaviour logBehaviour)
		{
			if (logBehaviour != LogBehaviour.Default)
			{
				if (logBehaviour != LogBehaviour.Verbose)
				{
					Debugger.logPriority = 0;
				}
				else
				{
					Debugger.logPriority = 2;
				}
			}
			else
			{
				Debugger.logPriority = 1;
			}
		}

		public static int logPriority;
	}
}
