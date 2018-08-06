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
		public class Pose2D : ROSBridgeMsg 
		{
			private double _x;
			private double _y;
			private double _theta;
			
			public Pose2D(JSONNode msg) 
			{
				_x = double.Parse(msg["x"]);
				_y = double.Parse(msg["y"]);
				_theta = double.Parse(msg["theta"]);
			}
			
			public Pose2D(double x, double y, double theta) 
			{
				_x = x;
				_y = y;
				_theta = theta;
			}
			
			public static string GetMessageType() 
			{
				return "geometry_msgs/Pose2D";
			}
			
			public double GetX()
			{
				return _x;
			}
			
			public double GetY() 
			{
				return _y;
			}

			public double GetTheta() 
			{
				return _theta;
			}
			
			public override string ToString() 
			{
				return "Pose2D [x=" + _x.ToString() + ",y=" + _y.ToString() + ",theta=" + _theta.ToString() + "]";
			}
			
			public override string ToYAMLString() 
			{
				return "{x : " + _x.ToString() + ",y : " + _y.ToString() + ",theta : " + _theta.ToString() + "}";
			}
		}
	}
}