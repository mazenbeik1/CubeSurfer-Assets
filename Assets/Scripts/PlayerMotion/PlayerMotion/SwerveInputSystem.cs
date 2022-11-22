using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveInputSystem : MonoBehaviour
{
    private float _lastFrameFingerPositionX;
    private float _moveFactoryX;
    public PlayerMoverRunner PlayerMoverRunner;

    public float MoveFactoryX { get => _moveFactoryX; }
    // Update is called once per frame
    void Update()
    {
        if (!PlayerMoverRunner.CanMotion)
		{
            return;
		}
        if(Input.GetMouseButtonDown(0))
		{
            _lastFrameFingerPositionX = Input.mousePosition.x;
		}
        else if(Input.GetMouseButton(0))
		{
            Vector3 currentMousePosition = Input.mousePosition;
            _moveFactoryX = (currentMousePosition.x) - (_lastFrameFingerPositionX);
            _lastFrameFingerPositionX = Input.mousePosition.x;
		}
        else if(Input.GetMouseButtonUp(0))
		{
            _moveFactoryX = 0f;
		}
    }
}
