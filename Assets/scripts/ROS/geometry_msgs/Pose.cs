using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ROS 
{
	namespace geometry_msgs 
	{
		public class Pose : ROSBridgeMsg 
		{
			private Point _position;
			private Quaternion _orientation;
			
			public Pose(JSONNode msg) 
			{
				_position = new Point(msg["position"]);
				_orientation = new Quaternion(msg["orientation"]);
			}
			
			public Pose(Point position, Quaternion orientation)
			{
			 	_position = position;
				_orientation = orientation;
			}
			
			public static string GetMessageType() 
			{
				return "std_msgs/Pose";
			}

			public Point GetPosition() 
			{
				return _position;
			}

			public Quaternion GetOrientation() 
			{
				return _orientation;
			}
			
			public override string ToString() 
			{
				return "Pose [position=" + _position.ToString() + ",orientation=" + _orientation.ToString() + "]";
			}
			
			public override string ToYAMLString() 
			{
				return "{position : " + _position.ToYAMLString() + ",orientation : " + _orientation.ToYAMLString() + "}";
			}
		}
	}
}