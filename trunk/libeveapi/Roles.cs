using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace libeveapi
{
    public class Roles
    {
        protected Hashtable rolesTable = new Hashtable();

        public Roles(string roleMask)
        {
            ulong mask = Convert.ToUInt64(roleMask);
            decodeRoles(mask);
        }

        public Roles(ulong roleMask)
        {
            decodeRoles(roleMask);
        }

        private void decodeRoles(ulong mask)
        {
            foreach (RoleTypes roleType in Enum.GetValues(typeof(RoleTypes)))
            {
                if (((ulong)roleType & mask) > 0)
                {
                    rolesTable.Add(roleType, 1);
                }
            }
        }

        /// <summary>
        /// Return true if the specified role is present
        /// </summary>
        /// <param name="roleType"></param>
        /// <returns></returns>
        public bool HasRole(RoleTypes roleType)
        {
            if (rolesTable.Contains(roleType))
            {
                return true;
            }

            return false;
        }

        

        /// <summary>
        /// Get the name of a role
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public static string GetRoleName(RoleTypes en)
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

        /// <summary>
        /// Get the description of a role
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public static string GetRoleDescription(RoleTypes en)
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

    /// <summary>
    /// The name of a role
    /// </summary>
    class Name : Attribute
    {
        public string Text;

        public Name(string text)
        {
            this.Text = text;
        }
    }

    /// <summary>
    /// The description of a role
    /// </summary>
    class Description : Attribute
    {
        public string Text;

        public Description(string text)
        {
            this.Text = text;
        }
    }

    /// <summary>
    /// Character Roles
    /// </summary>
    public enum RoleTypes : ulong
    {
        /// <summary>
        /// 
        /// </summary>
        [Name("Director")]
        [Description("A director is, for most intents and purposes, the same as a CEO in many respects. They can hire and fire members and change job descriptions (assigning both roles and grantable roles).")]
        Director = 1,

        /* The roles below exist but at current time their bitmask is unknown.
         * 
         */

        /*
        /// <summary>
        /// 
        /// </summary>
        [Name("Config Equipment")]
        [Description("This role allows the holder to anchor, unanchor, rename, and configure various types of objects in space.")]
        Director = 1,

        /// <summary>
        /// 
        /// </summary>
        [Name("Config Starbase")]
        [Description("This role allows the holder to perform star base configuration.")]
        Director = 1,

        /// <summary>
        /// 
        /// </summary>
        [Name("Junior Accountant")]
        [Description("The junior accountant is a cur down version of the accountant role. It essentially allows the holder to view the data that an accountant views. However it does not allow the holder to perform the actions that an accountant can.")]
        Director = 1,

        /// <summary>
        /// 
        /// </summary>
        [Name("Personnel Manager")]
        [Description("A personnel manager can process applications and sign up new members. ")]
        Director = 1,

        /// <summary>
        /// 
        /// </summary>
        [Name("Rent Factory")]
        [Description("This role allows the holder to rent factory slots for the corporation. ")]
        Director = 1,

        /// <summary>
        /// 
        /// </summary>
        [Name("Rent Office")]
        [Description("The role Rent Office allows the holder to rent offices for the corporation. ")]
        Director = 1,

        /// <summary>
        /// 
        /// </summary>
        [Name("Rent Research Facility")]
        [Description("This role allows the holder to rent research facilities for the corporation. ")]
        Director = 1,

        */

        /// <summary>
        /// 
        /// </summary>
        [Name("Personel Manager")]
        [Description("A personnel manager can process applications and sign up new members.")]
        PersonnelManager = 1 << 7,

        /// <summary>
        /// 
        /// </summary>
        [Name("Accountant")]
        [Description("Accountants can monitor and manage the financial affairs of the corporation. They can view corporation bills in the NeoCom �Bills� panel.")]
        Accountant = 1 << 8,

        /// <summary>
        /// 
        /// </summary>
        [Name("Security Manager")]
        [Description("The role security officer allows the holder to view the contents of the deliveries window in station. This is the window where items bought by the corporation at a station are placed. If the corporation has a corporate hangar at a station, the role Security Officer grants view access to the contents of the members' hangars. This access also facilitates the placing of items into the members' hangars.")]
        SecurityManager = 1 << 9,

        /// <summary>
        /// 
        /// </summary>
        [Name("Factory Manager")]
        [Description("The factory manager can eject blueprints from corporation-owned factories and research slots that belong to members. Additionally, they can see what is going on in any corporate factory and research slot. They have the ability to manufacture items for the corporation using blueprints and minerals from the corporation�s hangar floor and research blueprints in research slots. ")]
        FactoryManager = 1 << 10,

        /// <summary>
        /// 
        /// </summary>
        [Name("Station Manager")]
        [Description("As the name implies, station managers can perform station management tasks for corporation-owned facilities. These tasks are varied and include adjusting the standing-based modifiers for allowing docking and the charges for it, as well as permission to access factories, the reprocessing plant, the repair shop, and also how modifiers should be applied for costs based upon standings for these tasks.")]
        StationManager = 1 << 11,

        /// <summary>
        /// 
        /// </summary>
        [Name("Auditor")]
        [Description("The Auditor role allows the holder to check the role history of members of the corporation. ")]
        Auditor = 1 << 12,

        TakeFromDivision1Hangar = (ulong)1 << 13,
        TakeFromDivision2Hangar = (ulong)1 << 14,
        TakeFromDivision3Hangar = (ulong)1 << 15,
        TakeFromDivision4Hangar = (ulong)1 << 16,
        TakeFromDivision5Hangar = (ulong)1 << 17,
        TakeFromDivision6Hangar = (ulong)1 << 18,
        TakeFromDivision7Hangar = (ulong)1 << 19,
        QueryDivision1Hangar = (ulong)1 << 20,
        QueryDivision2Hangar = (ulong)1 << 21,
        QueryDivision3Hangar = (ulong)1 << 22,
        QueryDivision4Hangar = (ulong)1 << 23,
        QueryDivision5Hangar = (ulong)1 << 24,
        QueryDivision6Hangar = (ulong)1 << 25,
        QueryDivision7Hangar = (ulong)1 << 26,
        TakeFromDivision1Accounts = (ulong)1 << 27,
        TakeFromDivision2Accounts = (ulong)1 << 28,
        TakeFromDivision3Accounts = (ulong)1 << 29,
        TakeFromDivision4Accounts = (ulong)1 << 30,
        TakeFromDivision5Accounts = (ulong)1 << 31,
        TakeFromDivision6Accounts = (ulong)1 << 32,
        TakeFromDivision7Accounts = (ulong)1 << 33,
        QueryDivision1Accounts = (ulong)1 << 34,
        QueryDivision2Accounts = (ulong)1 << 35,
        QueryDivision3Accounts = (ulong)1 << 36,
        QueryDivision4Accounts = (ulong)1 << 37,
        QueryDivision5Accounts = (ulong)1 << 38,
        QueryDivision6Accounts = (ulong)1 << 39,
        QueryDivision7Accounts = (ulong)1 << 40,
        EquipmentConfigAndDeploySpace = (ulong)1 << 41
    }
}
