using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace libeveapi
{
    /// <summary>
    /// A Name Attribute
    /// </summary>
    class Name : Attribute
    {
        public string Text;

        public Name(string text)
        {
            this.Text = text;
        }
        
        /// <summary>
        /// Get the Name Attribute value
        /// </summary>
        /// <param name="en">Object</param>
        /// <returns>Name string</returns>
        public static string GetRoleName<T>(T en)
        {
            Type type = en.GetType();
            MemberInfo[] memberInfo = type.GetMember(en.ToString());

            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attributes = memberInfo[0].GetCustomAttributes(typeof(Name), false);
                if (attributes != null && attributes.Length > 0)
                {
                    return ((Name)attributes[0]).Text;
                }
            }
            return en.ToString();
        }
    }

    /// <summary>
    /// A Description Attribute
    /// </summary>
    class Description : Attribute
    {
        public string Text;

        public Description(string text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Get the description Attribute of the object
        /// </summary>
        /// <param name="en">Object</param>
        /// <returns>Description string</returns>
        public static string GetDescription<T>(T en)
        {
            Type type = en.GetType();
            MemberInfo[] memberInfo = type.GetMember(en.ToString());

            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attributes = memberInfo[0].GetCustomAttributes(typeof(Description), false);
                if (attributes != null && attributes.Length > 0)
                {
                    return ((Description)attributes[0]).Text;
                }
            }

            return en.ToString();
        }
    }
}