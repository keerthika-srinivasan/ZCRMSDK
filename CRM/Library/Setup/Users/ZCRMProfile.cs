﻿using System.Collections.Generic;
using ZCRMSDK.CRM.Library.Common;


namespace ZCRMSDK.CRM.Library.Setup.Users
{
    public class ZCRMProfile : ZCRMEntity
    {

        private long id;
        private string name;
        private ZCRMUser createdBy;
        private ZCRMUser modifiedBy;
        private string createdTime;
        private string modifiedTime;
        private bool category;
        private string description;
        private bool isDefault;
        private List<ZCRMProfilePermissions> permissionsDetails = new List<ZCRMProfilePermissions>();
        private List<ZCRMProfileSection> section = new List<ZCRMProfileSection>();

        private ZCRMProfile(long profileId, string profileName)
        {
            Id = profileId;
            Name = profileName;
        }

        /// <summary>
        /// To get ZohoCRM profile instance by passing profile Id and profile name.
        /// </summary>
        /// <returns>ZCRMProfile class instance.</returns>
        /// <param name="profileId">Id (Long) of the profile</param>
        /// <param name="profileName">Name (String) of the profile</param>
        public static ZCRMProfile GetInstance(long profileId, string profileName)
        {
            return new ZCRMProfile(profileId, profileName);
        }

        /// <summary>
        /// Gets the profile Id.
        /// </summary>
        /// <value>Id of the profile.</value>
        /// <returns>Long</returns>
        public long Id
        {
            get
            {
                return id;
            }
            private set
            {
                id = value;
            }
        }

        /// <summary>
        /// Gets the profile name.
        /// </summary>
        /// <value>Name of the profile.</value>
        /// <returns>String</returns>
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }

        /// <summary>
        /// Gets or sets the user who created the profile.
        /// </summary>
        /// <value>The user who created the profile.</value>
        /// <returns>ZCRMUser class instance</returns>
        public ZCRMUser CreatedBy
        {
            get
            {
                return createdBy;
            }
            set
            {
                createdBy = value;
            }
        }

        /// <summary>
        /// Gets or sets the user who modified the profile.
        /// </summary>
        /// <value>The user who modified the profile.</value>
        /// <returns>ZCRMUser class instance</returns>
        public ZCRMUser ModifiedBy
        {
            get
            {
                return modifiedBy;
            }
            set
            {
                modifiedBy = value;
            }
        }

        /// <summary>
        /// Gets or sets the created time of/for the profile.
        /// </summary>
        /// <value>The created time of the profile.</value>
        /// <returns>String</returns>
        public string CreatedTime
        {
            get
            {
                return createdTime;
            }
            set
            {
                createdTime = value;
            }
        }

        /// <summary>
        /// Gets or sets the modified time of/for the profile.
        /// </summary>
        /// <value>The modified time of the profile.</value>
        /// <string>String</string>
        public string ModifiedTime
        {
            get
            {
                return modifiedTime;
            }
            set
            {
                modifiedTime = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this profiles' category.
        /// </summary>
        /// <value><c>true</c> if category; otherwise, <c>false</c>.</value>
        /// <return>Boolean</return>
        public bool Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        /// <summary>
        /// Gets or sets the profiles' description.
        /// </summary>
        /// <value>The description of the profile.</value>
        /// <return>String</return>
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:ZCRMSDK.CRM.Library.Setup.Users.ZCRMProfile"/> is isdefault.
        /// </summary>
        /// <value><c>true</c> if isdefault; otherwise, <c>false</c>.</value>
        public bool IsDefault
        {
            get
            {
                return isDefault;
            }
            set
            {
                isDefault = value;
            }
        }

        public List<ZCRMProfilePermissions> PermissionsDetails
        {
            get
            {
                return permissionsDetails;
            }
            set
            {
                permissionsDetails = value;
            }
        }

        public void SetPermissionsDetails(ZCRMProfilePermissions permission)
        {
            PermissionsDetails.Add(permission);
        }

        public List<ZCRMProfileSection> Section
        {
            get
            {
                return section;
            }
            set
            {
                section = value;
            }
        }

        public void SetProfileSection(ZCRMProfileSection section)
        {
            Section.Add(section);
        }
    }
}
