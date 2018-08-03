using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ROS {
	namespace std_msgs {
		public class UInt32MultiArray : ROSBridgeMsg {
			private MultiArrayLayout _layout;
			private List<uint> _data;
			
			public UInt32MultiArray(JSONNode msg) 
			{
				JSONArray data = (JSONArray) msg["data"];
				List<uint> list = new List<uint> ();
				for(int i=0; i<data.Count; i++)
				{ 
					list.Add(Convert.ToUInt32(data[i]));
				}
				_data = list;
				_layout = new MultiArrayLayout(msg["layout"]);
			}
			
			public UInt32MultiArray(MultiArrayLayout layout, List<uint> data)
			{
			 	_layout = layout;
				_data = data;
			}
			
			public static string GetMessageType() 
			{
				return "std_msgs/UInt32MultiArray";
			}
			
			public MultiArrayLayout GetLayout() 
			{
				return _layout;
			}

			public List<uint> GetData() 
			{
				return _data;
			}
			
			public override string ToString() 
			{
				string str;
                str="[";
				for(int i=0; i<_data.Count; i++)
				{ 
					str = str + _data[i].ToString();
					if(i != _data.Count-1)
					{
						str = str + ",";
					}
				}
				str = str + "]";

				return "UInt32MultiArray [layout=" + _layout.ToString() + ",data=" + str + "]";
			}
			
			public override string ToYAMLString() 
			{
				string str;
                str="[";
				for(int i=0; i<_data.Count; i++)
				{ 
					str = str + _data[i].ToString();
					if(i != _data.Count-1)
					{
						str = str + ",";
					}
				}
				str = str + "]";
				
				return "{layout : " + _layout.ToYAMLString() + ",data : " +str + "}";
			}
		}
	}
}