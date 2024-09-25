using JetBrains.Rider.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour
{
    public Camera m_Camera;
    public float m_flSpeed;
    public float m_flSensitivity;

    private Rigidbody m_Rb;

    // Start is called before the first frame update
    void Start()
    {
        m_Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vecVelocity = Vector3.zero;
        vecVelocity.z = Input.GetAxisRaw( "Vertical" ) * m_flSpeed;
        vecVelocity.x = Input.GetAxisRaw( "Horizontal" ) * m_flSpeed;
        m_Rb.velocity = vecVelocity;

        float flMx = ( Input.GetAxis( "Mouse X" ) * m_flSensitivity ) * Time.deltaTime;

        m_Camera.transform.Rotate( 0, flMx, 0 );
    }
}
