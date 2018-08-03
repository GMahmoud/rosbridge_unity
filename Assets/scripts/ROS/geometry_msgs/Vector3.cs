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
		public class Vector3 : ROSBridgeMsg 
		{
			private double _x;
			private double _y;
			private double _z;
			
			public Vector3(JSONNode msg) 
			{
				_x = double.Parse(msg["x"]);
				_y = double.Parse(msg["y"]);
				_z = double.Parse(msg["z"]);
			}
			
			public Vector3(double x, double y, double z) 
			{
				_x = x;
				_y = y;
				_z = z;
			}
			
			public static string GetMessageType() 
			{
				return "geometry_msgs/Vector3";
			}
			
			public double GetX()
			{
				return _x;
			}
			
			public double GetY() 
			{
				return _y;
			}

			public double GetZ() 
			{
				return _z;
			}
			
			public override string ToString() 
			{
				return "Vector3 [x=" + _x.ToString() + ",y=" + _y.ToString() + ",z=" + _z + "]";
			}
			
			public override string ToYAMLString() 
			{
				return "{x=" + _x.ToString() + ",y=" + _y.ToString() + ",z=" + _z + "}";
			}
		}
	}
}