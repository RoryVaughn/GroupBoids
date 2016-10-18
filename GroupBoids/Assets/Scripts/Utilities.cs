﻿using UnityEngine;
using System.Collections;

static class Utilities{

    public static Vector3 AVec3toUVec3(Agent.Vector3 apos)
    {
        Vector3 upos;
        upos.x = apos.x;
        upos.y = apos.y;
        upos.z = apos.z;
        return upos;
    }

    public static Agent.Vector3 UVec3toAVec3(Vector3 apos)
    {
        Agent.Vector3 upos;
        upos.x = apos.x;
        upos.y = apos.y;
        upos.z = apos.z;
        return upos;
    }
    public static Agent.Vector3 Invert(Vector3 apos)
    {
        Agent.Vector3 upos;
        upos.x = -1 * apos.x;
        upos.y = apos.y;
        upos.z = -1 *apos.z;
        return upos;
    }
}
