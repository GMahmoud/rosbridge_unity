using System.Collections;
using System.Text;
using SimpleJSON;
using UnityEngine;
using ROSBridge;
using System;

namespace ROS 
{
	namespace geometry_msgs 
	{
		public class Point32 : ROSBridgeMsg 
		{
			private float _x;
			private float _y;
			private float _z;
			
			public Point32(JSONNode msg) 
			{
				_x = float.Parse(msg["x"]);
				_y = float.Parse(msg["y"]);
				_z = float.Parse(msg["z"]);
			}
			
			public Point32(float x, float y, float z) 
			{
				_x = x;
				_y = y;
				_z = z;
			}
			
			public static string GetMessageType() 
			{
				return "geometry_msgs/Point32";
			}
			
			public float GetX()
			{
				return _x;
			}
			
			public float GetY() 
			{
				return _y;
			}

			public float GetZ() 
			{
				return _z;
			}
			
			public override string ToString() 
			{
				return "Point32 [x=" + _x.ToString() + ",y=" + _y.ToString() + ",z=" + _z + "]";
			}
			
			public override string ToYAMLString() 
			{
				return "{x=" + _x.ToString() + ",y=" + _y.ToString() + ",z=" + _z + "}";
			}
		}
	}
}