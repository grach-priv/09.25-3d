using JetBrains.Rider.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BasePlayer : MonoBehaviour
{
    [ SerializeField ] private float m_flSpeed;
    [ SerializeField ] private float m_flSensitivity;

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
#if TRUE
        vecVelocity.z = Input.GetAxisRaw( "Vertical" ) * m_flSpeed;
        vecVelocity.x = Input.GetAxisRaw( "Horizontal" ) * m_flSpeed;
#else
        switch( Input.inputString )
        {
            case "w":
                break;
            case "a":
                break;
            case "s":
                break;
            case "d":
                break;
        }
#endif
        m_Rb.velocity = vecVelocity;

        float flMx = ( Input.GetAxis( "Mouse X" ) * m_flSensitivity ) * Time.deltaTime;

        // todo; wasd rotateuje tylko tak jakby gracz w pó³noc ca³y czas patrzy³
        m_Rb.transform.Rotate(0, flMx, 0);
        transform.Rotate( 0, flMx, 0 );
    }
}
