using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMovement : MonoBehaviour
{
    [SerializeField]
    private SwerveInputSystem swerveInputSystem;

    [SerializeField]
    private float swerveSpeed = 0.5f;

    [SerializeField]
    private float maxSwerveAmount = 1f;

    public PlayerMoverRunner PlayerMoverRunner;

    private void Update()
    {
        if (!PlayerMoverRunner.CanMotion)
        {
            return;
        }
        float swerveAmount = Time.deltaTime * swerveSpeed * swerveInputSystem.MoveFactoryX;
        swerveAmount = Mathf.Clamp(swerveAmount, -maxSwerveAmount, maxSwerveAmount);
        transform.Translate(swerveAmount, 0f, 0f);
        
    }
}
