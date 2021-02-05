using UnityEngine;
using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour 
{
	public Transform[] Transforms;

	private int currentIndex;

	void Awake()
	{
		SnapToPosition(0);
	}


	public void SnapToPosition(int index)
	{
		/*this.currentIndex = index;
		this.transform.position = this.Transforms[index].position;
		this.transform.rotation = this.Transforms[index].rotation;*/
		if (this.currentIndex != index) {
			float time = 1f;
			Vector3 startPosition = this.transform.position;
			Quaternion startRotation = this.transform.rotation;
			Vector3 endPosition = this.Transforms [index].position;
			Quaternion endRotation = this.Transforms [index].rotation;

			this.currentIndex = index;
			float elapsedTime = 0;
			while (elapsedTime < time) {
				float a = elapsedTime / time;
				this.transform.position = Vector3.Lerp (startPosition, endPosition, Mathf.SmoothStep (0, 2, a));
				this.transform.rotation = Quaternion.Slerp (startRotation, endRotation, Mathf.SmoothStep (0, 2, a));
				elapsedTime += Time.deltaTime;
			}
		}
	}

	public IEnumerator MoveToPosition(int index, float time)
	{
		if (this.currentIndex == index)
		{
			yield break;
		}
		Vector3 startPosition = this.transform.position;
		Quaternion startRotation = this.transform.rotation;
		Vector3 endPosition = this.Transforms[index].position;
		Quaternion endRotation = this.Transforms[index].rotation;

		this.currentIndex = index;
		float elapsedTime = 0;
		while (elapsedTime < time)
		{
			float a = elapsedTime / time;
			this.transform.position = Vector3.Lerp(startPosition, endPosition, Mathf.SmoothStep(0,2,a));
			this.transform.rotation = Quaternion.Slerp(startRotation, endRotation, Mathf.SmoothStep(0,2,a));

			yield return new WaitForEndOfFrame();
			elapsedTime += Time.deltaTime;
		}
	}

	}