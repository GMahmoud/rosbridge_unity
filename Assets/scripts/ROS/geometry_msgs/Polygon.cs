using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ROS {
	namespace geometry_msgs {
		public class Polygon : ROSBridgeMsg {
			private List<Point32> _points;
			
			public Polygon(JSONNode msg) 
			{
				JSONArray points = (JSONArray) msg["points"];
				Point32 element ; 
				List<Point32> list = new List<Point32> ();
				for(int i=0; i<points.Count; i++)
				{ 
					element = new Point32(points[i]);
					list.Add(element);
				}
				_points = list;
			}
			
			public Polygon(List<Point32> points)
			{
			 	_points = points;
			}
			
			public static string GetMessageType() 
			{
				return "std_msgs/Polygon";
			}

			public List<Point32> GetPoints() 
			{
				return _points;
			}
			
			public override string ToString() 
			{
				string str;
                str="[";
				for(int i=0; i<_points.Count; i++)
				{ 
					str = str + _points[i].ToString();
					if(i != _points.Count-1)
					{
						str = str + ",";
					}
				}
				str = str + "]";

				return "Polygon [points=" + str + "]";
			}
			
			public override string ToYAMLString() 
			{
				string str;
                str="[";
				for(int i=0; i<_points.Count; i++)
				{ 
					str = str + _points[i].ToYAMLString();
					if(i != _points.Count-1)
					{
						str = str + ",";
					}
				}
				str = str + "]";
				
				return "{points : " + str + "}";
			}
		}
	}
}