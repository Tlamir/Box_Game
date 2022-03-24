using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Speed = 10f;
    public float SwipeSpeed = 10f;
    public float MoveFactorX => _moveFactorX;
    private float xPosMin = -0.84f;
    private float xPosMax = 2.76f;
    private float _moveFactorX;
    private float _lastFrameFingerPositionX;

    [SerializeField]
    private float swerveSpeed = 0.5f;
    [SerializeField]
    private float maxSwerveAmount = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 translate1 = (new Vector3(0, 0, 1) * Time.deltaTime) * Speed;
        transform.Translate(translate1);


        if (Input.GetMouseButtonDown(0))
        {

            _lastFrameFingerPositionX = Input.mousePosition.x;
            //Play Animation Here

        }
        else if (Input.GetMouseButton(0))
        {
            _moveFactorX = Input.mousePosition.x - _lastFrameFingerPositionX;
            _lastFrameFingerPositionX = Input.mousePosition.x;
            MovePlayer();

        }
        else if (Input.GetMouseButtonUp(0))
        {
            _moveFactorX = 0f;
            Vector3 translate = (new Vector3(0, 0, 1) * Time.deltaTime) * Speed;
            transform.Translate(translate);
        }
    }


    public void MovePlayer()
    {
        float swerveAmount = Time.deltaTime * swerveSpeed * MoveFactorX;
        swerveAmount = Mathf.Clamp(swerveAmount, -maxSwerveAmount, maxSwerveAmount);
        transform.Translate(swerveAmount, 0, 0);

        //Limit player movment in x axis
        float xPos = Mathf.Clamp(transform.position.x, xPosMin, xPosMax);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }
}
