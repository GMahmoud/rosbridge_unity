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
		public class Vector3Stamped : ROSBridgeMsg 
		{
			private Header _header;
			private Vector3 _vector;
			
			public Vector3Stamped(JSONNode msg) 
			{
				_header = new Header(msg["header"]);
				_vector = new Vector3(msg["vector"]);
			}
			
			public Vector3Stamped(Header header, Vector3 vector) 
			{
				_header = header;
				_vector = vector;
			}
			
			public static string GetMessageType() 
			{
				return "geometry_msgs/Vector3Stamped";
			}
			
			public Header GetHeader()
			{
				return _header;
			}
			
			public Vector3 GetVector() 
			{
				return _vector;
			}
			
			public override string ToString() 
			{
				return "Vector3Stamped [header=" + _header.ToString() + ",vector=" + _vector.ToString() + "]";
			}
			
			public override string ToYAMLString() 
			{
				return "{header : " + _header.ToYAMLString() + ",vector : " + _vector.ToYAMLString() + "}";
			}
		}
	}
}