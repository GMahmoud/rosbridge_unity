using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ROS {
	namespace std_msgs {
		public class Float64MultiArray : ROSBridgeMsg {
			private MultiArrayLayout _layout;
			private List<double> _data;
			
			public Float64MultiArray(JSONNode msg) 
			{
				JSONArray data = (JSONArray) msg["data"];
				List<double> list = new List<double> ();
				for(int i=0; i<data.Count; i++)
				{ 
					list.Add(double.Parse(data[i]));
				}
				_data = list;
				_layout = new MultiArrayLayout(msg["layout"]);
			}
			
			public Float64MultiArray(MultiArrayLayout layout, List<double> data)
			{
			 	_layout = layout;
				_data = data;
			}
			
			public static string GetMessageType() 
			{
				return "std_msgs/Float64MultiArray";
			}
			
			public MultiArrayLayout GetLayout() 
			{
				return _layout;
			}

			public List<double> GetData() 
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

				return "Float64MultiArray [layout=" + _layout.ToString() + ",data=" + str + "]";
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