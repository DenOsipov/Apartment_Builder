﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nox7atra.ApartmentEditor
{
    public static class ExtentionMethods
    {
        public static Vector2 RoundCoordsToInt(this Vector2 vec)
        {
            return new Vector2(Mathf.RoundToInt(vec.x), Mathf.RoundToInt(vec.y));
        }
    }
}