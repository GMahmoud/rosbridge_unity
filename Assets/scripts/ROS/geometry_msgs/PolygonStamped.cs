using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;
using System.Collections.Generic;
using UnityEngine;
using ROS.std_msgs;

namespace ROS {
	namespace geometry_msgs {
		public class PolygonStamped : ROSBridgeMsg 
		{
			private Header _header;
			private Polygon _polygon;
			
			public PolygonStamped(JSONNode msg) 
			{
				_header = new Header(msg["header"]);
				_polygon = new Polygon(msg["polygon"]);
			}
			
			public PolygonStamped(Header header, Polygon polygon)
			{
				_header = header;
			 	_polygon = polygon;
			}
			
			public static string GetMessageType() 
			{
				return "std_msgs/PolygonStamped";
			}

			public Header GetHeader() 
			{
				return _header;
			}

			public Polygon GetPolygon() 
			{
				return _polygon;
			}
			
			public override string ToString() 
			{
				return "PolygonStamped [header=" + _header.ToString() + ",polygon=" + _polygon.ToString() + "]";
			}
			
			public override string ToYAMLString() 
			{
				return "{header : " + _header.ToYAMLString() + ",polygon : " + _polygon.ToYAMLString() + "}";
			}
		}
	}
}