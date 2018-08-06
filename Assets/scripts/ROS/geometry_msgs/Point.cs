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
		public class Point : ROSBridgeMsg 
		{
			private double _x;
			private double _y;
			private double _z;
			
			public Point(JSONNode msg) 
			{
				_x = double.Parse(msg["x"]);
				_y = double.Parse(msg["y"]);
				_z = double.Parse(msg["z"]);
			}
			
			public Point(double x, double y, double z) 
			{
				_x = x;
				_y = y;
				_z = z;
			}
			
			public static string GetMessageType() 
			{
				return "geometry_msgs/Point";
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
				return "Point [x=" + _x.ToString() + ",y=" + _y.ToString() + ",z=" + _z.ToString() + "]";
			}
			
			public override string ToYAMLString() 
			{
				return "{x : " + _x.ToString() + ",y : " + _y.ToString() + ",z : " + _z.ToString() + "}";
			}
		}
	}
}