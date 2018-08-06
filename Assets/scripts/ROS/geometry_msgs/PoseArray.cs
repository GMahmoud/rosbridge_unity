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
		public class PoseArray : ROSBridgeMsg {
			private Header _header;
			private List<Pose> _poses;
			
			public PoseArray(JSONNode msg) 
			{
				JSONArray poses = (JSONArray) msg["poses"];
				Pose element;
				List<Pose> list = new List<Pose> ();
				for(int i=0; i<poses.Count; i++)
				{ 
					element = new Pose(poses[i]);
					list.Add(element);
				}
				_poses = list;
				_header = new Header(msg["header"]);
			}
			
			public PoseArray(Header header, List<Pose> poses)
			{
			 	_poses = poses;
				_header = header;
			}
			
			public static string GetMessageType() 
			{
				return "std_msgs/PoseArray";
			}
			
			public Header GetHeader() 
			{
				return _header;
			}

			public List<Pose> GetPoses() 
			{
				return _poses;
			}
			
			public override string ToString() 
			{
				string str;
                str="[";
				for(int i=0; i<_poses.Count; i++)
				{ 
					str = str + _poses[i].ToString();
					if(i != _poses.Count-1)
					{
						str = str + ",";
					}
				}
				str = str + "]";

				return "PoseArray [header=" + _header.ToString() + ",poses=" + str + "]";
			}
			
			public override string ToYAMLString() 
			{
				string str;
                str="[";
				for(int i=0; i<_poses.Count; i++)
				{ 
					str = str + _poses[i].ToYAMLString();
					if(i != _poses.Count-1)
					{
						str = str + ",";
					}
				}
				str = str + "]";
				
				return "{header : " + _header.ToYAMLString() + ",poses : " +str + "}";
			}
		}
	}
}