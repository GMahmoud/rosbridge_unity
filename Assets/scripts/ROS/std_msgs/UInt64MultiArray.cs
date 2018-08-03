using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ROS {
	namespace std_msgs {
		public class UInt64MultiArray : ROSBridgeMsg {
			private MultiArrayLayout _layout;
			private List<ulong> _data;
			
			public UInt64MultiArray(JSONNode msg) 
			{
				JSONArray data = (JSONArray) msg["data"];
				List<ulong> list = new List<ulong> ();
				for(int i=0; i<data.Count; i++)
				{ 
					list.Add(Convert.ToUInt64(data[i]));
				}
				_data = list;
				_layout = new MultiArrayLayout(msg["layout"]);
			}
			
			public UInt64MultiArray(MultiArrayLayout layout, List<ulong> data)
			{
			 	_layout = layout;
				_data = data;
			}
			
			public static string GetMessageType() 
			{
				return "std_msgs/UInt64MultiArray";
			}
			
			public MultiArrayLayout GetLayout() 
			{
				return _layout;
			}

			public List<ulong> GetData() 
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

				return "UInt64MultiArray [layout=" + _layout.ToString() + ",data=" + str + "]";
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