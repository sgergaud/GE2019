using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangentCircles1 : CircleTangent
{
    [Header("Setup")]
    public GameObject _circlePrefab;
    private GameObject _innerCircleGO, _outterCircleGO;
    private Vector4 _innerCircle, _outterCircle;
    public float _innerCircleRadius, _outterCircleRadius;
    private Vector4[] _tangentCircle;
    private GameObject[] _tangentObject;
    [Range(1, 64)]
    public int _circleAmount;

    [Header("Input")]
    [Range(0, 1)]
    public float _distOuterTangent;
    [Range(0, 1)]
    public float _movementSmooth;
    [Range(0.1f, 10f)]
    public float _radiusChangeSpeed;
    private Vector2 _tsL, _tsLSmooth; //ThumbstickLeft
    public float _radiusChange;

    private float _rotateTangenteObjects;
    public float _rotateSpeed;

   
    // Start is called before the first frame update
    void Start()
    {
        _innerCircle = new Vector4(0, 0, 0, _innerCircleRadius);
        _outterCircle = new Vector4(0, 0, 0, _outterCircleRadius);

        _tangentCircle = new Vector4[_circleAmount];
        _tangentObject = new GameObject[_circleAmount];
        

        //Spawn the object
        for (int i=0; i < _circleAmount; i++)
        {
            GameObject tangentInstance = (GameObject)Instantiate(_circlePrefab);
            _tangentObject[i] = tangentInstance;
            _tangentObject[i].transform.parent = this.transform;
           


        }
    }

    void PlayerInput()
    {
        _tsL = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        _tsLSmooth = new Vector2(
            _tsLSmooth.x * (1 - _movementSmooth) + _tsL.x * _movementSmooth,
            _tsLSmooth.y * (1 - _movementSmooth) + _tsL.y * _movementSmooth );

        _radiusChange = Input.GetAxis("TriggerL") - Input.GetAxis("TriggerR");

        _innerCircle = new Vector4 (
            (_tsLSmooth.x * (_outterCircle.w - _innerCircle.w) * (1 - _distOuterTangent)) + _outterCircle.x,
             0.0f,
            (_tsLSmooth.y * (_outterCircle.w - _innerCircle.w) * (1 - _distOuterTangent)) + _outterCircle.z,
            _innerCircle.w + (_radiusChange * Time.deltaTime * _radiusChangeSpeed));


    }
    // Update is called once per frame
    void Update()
    {
        PlayerInput();




        for (int i = 0; i < _circleAmount; i++)
        {
            _tangentCircle[i] = FindTangentCircle(_outterCircle, _innerCircle, (360f / _circleAmount) * i);
            _tangentObject[i].transform.position = new Vector3(_tangentCircle[i].x, _tangentCircle[i].y, _tangentCircle[i].z);
            _tangentObject[i].transform.localScale = new Vector3(_tangentCircle[i].w, _tangentCircle[i].w, _tangentCircle[i].w) * 2;
        }   
      
    }

}
