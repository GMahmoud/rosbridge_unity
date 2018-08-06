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
		public class Quaternion : ROSBridgeMsg 
		{
			private double _x;
			private double _y;
			private double _z;
			private double _w;
			
			public Quaternion(JSONNode msg) 
			{
				_x = double.Parse(msg["x"]);
				_y = double.Parse(msg["y"]);
				_z = double.Parse(msg["z"]);
				_w = double.Parse(msg["w"]);
			}
			
			public Quaternion(double x, double y, double z, double w) 
			{
				_x = x;
				_y = y;
				_z = z;
				_w = w;
			}
			
			public static string GetMessageType() 
			{
				return "geometry_msgs/Quaternion";
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

			public double GetW() 
			{
				return _w;
			}
			
			public override string ToString() 
			{
				return "Quaternion [x=" + _x.ToString() + ",y=" + _y.ToString() + ",z=" + _z.ToString() + ",w=" + _w.ToString() + "]";
			}
			
			public override string ToYAMLString() 
			{
				return "{x : " + _x.ToString() + ",y : " + _y.ToString() + ",z : " + _z.ToString() + ",w : " + _w.ToString() + "}";
			}
		}
	}
}