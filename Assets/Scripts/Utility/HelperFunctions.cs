﻿using System;
using UnityEngine;

public static class HelperFunctions
{
    public static int[] SecondsToHMS(int seconds)
    {
        int s = seconds % 60;
        int m = seconds / 60;
        int h = m / 60;

        return new int[] { h, m, s };
    }

    // Code referenced: https://www.codegrepper.com/code-examples/csharp/c%23+get+array+subarray
    public static T[] SubArray<T>(this T[] array, int offset, int length)
    {
        T[] result = new T[length];
        Array.Copy(array, offset, result, 0, length);
        return result;
    }

    // Code referenced: https://www.youtube.com/playlist?list=PLzDRvYVwl53v5ur4GluoabyckImZz3TVQ
    public static float GetAngleFromVectorFloat(Vector3 direction)
    {
        direction = direction.normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        if (angle < 0) angle += 360;

        return angle;
    }
}
