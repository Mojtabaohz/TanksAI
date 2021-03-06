﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// The event data that is generated when another participant in the arena was 'seen'
/// </summary>
public class ScannedRobotEvent {
    public string Name;
    public float Distance;
    public Transform Transform;
    
}



public class BaseAI : MonoBehaviour
{
    public TankController Tank = null;
    

    /// <summary>
    /// Another participant was 'seen'. Do something with the info stored in the even data
    /// </summary>
    /// <param name="e">The event data</param>
    public virtual void OnScannedRobot(ScannedRobotEvent e)
    {
        //Debug.Log("new tank scanned");
    }

   

    /// <summary>
    /// Move this Tank ahead by the given distance
    /// </summary>
    /// <param name="distance">The distance to move</param>
    /// <returns></returns>
    public void Ahead(float distance) {
        Tank.__Ahead(distance);
    }

    public void MoveToTarget(Transform target)
    {
        Tank.__MoveToTarget(target);
    }
    /// <summary>
    /// Move the ship backwards by the given distance
    /// </summary>
    /// <param name="distance">The distance to move</param>
    /// <returns></returns>
    public IEnumerator Back(float distance) {
        yield return Tank.__Back(distance);
    }

    /// <summary>
    /// Turn the sensor to the left by the given angle
    /// </summary>
    /// <param name="angle">The angle to rotate</param>
    /// <returns></returns>
    
    

    /// <summary>
    /// Turns the ship left by the given angle
    /// </summary>
    /// <param name="angle">The angle to rotate</param>
    /// <returns></returns>
    

    /// <summary>
    /// Turns the ship right by the given angle
    /// </summary>
    /// <param name="angle">The angle to rotate</param>
    /// <returns></returns>
    

    /// <summary>
    /// Fire from the forward pointing cannon
    /// </summary>
    /// <param name="power">???</param>
    /// <returns></returns>
    public void Fire() {
        Tank.__Fire();
    }

    /// <summary>
    /// Fire from the left pointing cannon
    /// </summary>
    /// <param name="power">???</param>
    /// <returns></returns>
    //public IEnumerator FireLeft(float power) {
    //    yield return Tank.__FireLeft(power);
    //}

    /// <summary>
    /// fire from the right pointing cannon
    /// </summary>
    /// <param name="power">???</param>
    /// <returns></returns>
    //public IEnumerator FireRight(float power) {
    //    yield return Tank.__FireRight(power);
    //}

    public virtual void RunAI() {
        
    }
}
