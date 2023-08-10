using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace T01.Stealer
{
    public class Spy
    {

        public string StealFieldInfo(string investegatedClass,params string[] requestedFields)
        {
            Type classType = Type.GetType(investegatedClass);
            FieldInfo[] classFields = classType.GetFields(
                BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            object classInstance = Activator.CreateInstance(classType, new object[] { });
            StringBuilder sb = new();
            sb.AppendLine($"Class under investigation: {investegatedClass}");
            foreach ( var field in classFields ) 
            { 
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }
            return sb.ToString().Trim();
        }
    }
}
