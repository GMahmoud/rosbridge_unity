using System.Collections;
using System.Text;
using SimpleJSON;
using UnityEngine;
using ROSBridge;
using System;
using ROS.std_msgs;

namespace ROS 
{
	namespace geometry_msgs 
	{
		public class PointStamped : ROSBridgeMsg 
		{
			private Header _header;
			private Point _point;
			
			public PointStamped(JSONNode msg) 
			{
				_header = new Header(msg["header"]);
				_point = new Point(msg["point"]);
			}
			
			public PointStamped(Header header, Point point) 
			{
				_header = header;
				_point = point;
			}
			
			public static string GetMessageType() 
			{
				return "geometry_msgs/PointStamped";
			}
			
			public Header GetHeader()
			{
				return _header;
			}
			
			public Point GetPoint() 
			{
				return _point;
			}
			
			public override string ToString() 
			{
				return "PointStamped [header=" + _header.ToString() + ",point=" + _point.ToString() + "]";
			}
			
			public override string ToYAMLString() 
			{
				return "{header=" + _header.ToYAMLString() + ",point=" + _point.ToYAMLString() + "}";
			}
		}
	}
}