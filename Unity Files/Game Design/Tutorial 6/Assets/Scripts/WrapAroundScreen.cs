using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapAroundScreen : MonoBehaviour
{
	private void LateUpdate()
		{
		Vector3 viewportPosition = Camera.main.WorldToViewportPoint(transform.position);

		if (viewportPosition.x > 1.0f) {
			viewportPosition.x = viewportPosition.x - 1.0f;
			}
		if (viewportPosition.x < 0.0f) { 
			viewportPosition.x = viewportPosition.x + 1.0f;
			}
		if (viewportPosition.y > 1.0f) { 
			viewportPosition.y = viewportPosition.y - 1.0f;
			}
		if (viewportPosition.y < 0.0f) { 
			viewportPosition.y = viewportPosition.y + 1.0f;
			}

		Vector3 wrappedViewportPosition = Camera.main.ViewportToWorldPoint(viewportPosition);
		transform.position = wrappedViewportPosition;
		}
	}
