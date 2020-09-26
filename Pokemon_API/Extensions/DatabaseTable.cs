using System.Collections.Generic;
using System.Linq;

namespace Pokemon_API.Extensions
{
    public abstract class DatabaseTable<T>
    {
        public Dictionary<string, object> ToDict()
        {
            System.Type obj = typeof(T);
            System.Reflection.PropertyInfo[] properties = obj.GetProperties();
            List<string> propertyNames = properties.Select(p => p.Name).ToList();
            List<object> propertyValues = properties.Select(p => p.GetValue(this)).ToList();

            if (propertyNames.Count != propertyValues.Count)
            {
                throw new KeyNotFoundException("field names and values do not match");
            }

            Dictionary<string, object> dict = new Dictionary<string, object>();
            for (int i = 0; i < propertyNames.Count; i++)
            {
                dict.Add(propertyNames[i].ToLower(), propertyValues[i]);
            }
            return dict;
        }

        public override bool Equals(object obj)
        {
            DatabaseTable<T> item = obj as DatabaseTable<T>;
            if (item == null)
            {
                return false;
            }

            Dictionary<string, object> inputDict = item.ToDict();
            Dictionary<string, object> curValsDict = this.ToDict();

            if (inputDict.Count != curValsDict.Count)
            {
                throw new KeyNotFoundException("input class and current class are different sizes");
            }

            if (!curValsDict.Keys.All(key => inputDict.ContainsKey(key)))
            {
                throw new KeyNotFoundException("input class and current class variable names do not match");
            }

            foreach(KeyValuePair<string,object> pair in curValsDict)
            {

                if(pair.Value == null && curValsDict[pair.Key] == null)
                {
                    continue;
                }

                var val = inputDict[pair.Key];
                if(!val.Equals(pair.Value))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}
