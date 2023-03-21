using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Reflection;

namespace Business
{
    //Use List<Business.movieData> mlist = BLL.ConvertHelper<Business.movieData>.ConvertToList(movie.Get());
    public class ConvertHelper<T> where T : new()
    {
        /// <summary>  
        
        /// </summary>  
        /// <param name="dt"></param>  
        /// <returns></returns>  
        public static List<T> ConvertToList(DataTable dt)
        {

            // define collection
            List<T> ts = new List<T>();

            // get the type of this model
            Type type = typeof(T);
            //Define a temporary variable
            string tempName = string.Empty;
            //Loop through all data rows in the DataTable
            foreach (DataRow dr in dt.Rows)
            {
                T t = new T();
                // Get the public properties of this model
                PropertyInfo[] properties = t.GetType().GetProperties();
                //Loop through all properties of the object
                foreach (PropertyInfo pi in properties)
                {
                    tempName = pi.Name;//Assign the attribute name to the temporary variable
                                       //Check if the DataTable contains this column (column name==property name of the object)
                    if (dt.Columns.Contains(tempName))
                    {
                        // Determine whether this property has a Setter
                        if (!pi.CanWrite) continue;//This attribute cannot be written, jump out directly
                                                   //value
                        object value = dr[tempName];
                        //If non-null, assign to the object's properties
                        if (value != DBNull.Value)
                            pi.SetValue(t, value, null);
                    }
                }
                //Add the object to the generic collection
                ts.Add(t);
            }
            return ts;

        }

    }


}
