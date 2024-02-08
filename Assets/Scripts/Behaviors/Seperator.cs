using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seperator : Kinematic
{
    Separation myMoveType;
    Align myRotateType;

    public Kinematic[] targets;

    // Start is called before the first frame update
    void Start()
    {
        myMoveType = new Separation();
        myMoveType.character = this;
        //myMoveType.target = myTarget;
        myMoveType.targets = targets;

        myRotateType = new Align();
        myRotateType.character = this;
        myRotateType.target = myTarget;
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = myRotateType.getSteering().angular;
        base.Update();
    }
}
