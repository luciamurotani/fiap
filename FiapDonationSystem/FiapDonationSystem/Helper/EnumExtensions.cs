using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace FiapDonationSystem.Helper
{
    public static class EnumExtensions
    {
        /// <summary>

        /// Fetch the description of the <paramref name="enumType"/> enumeration value.

        /// </summary>

        /// <param name="enumType">Enumeration value for which to return the description.</param>

        /// <returns>The description of the provided enumeration value.</returns>

        public static string Description(this System.Enum enumType)

        {

            var memInfo = enumType.GetType().GetMember(enumType.ToString());



            if (memInfo != null && memInfo.Length > 0)

            {

                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);



                if (attrs != null && attrs.Length > 0)

                    return ((DescriptionAttribute)attrs[0]).Description;

            }

            return enumType.ToString();

        }



        /// <summary>

        /// Indicates wether the <paramref name="enumType"/> enum value has a description.

        /// </summary>

        /// <param name="enumType">Enumeration value for which to indicate wether is has a description.</param>

        /// <returns>true if a description is defined on the enumeration value ; otherwise false.</returns>

        public static bool HasDescription(this System.Enum enumType)

        {

            return !string.IsNullOrWhiteSpace(enumType.Description());

        }

    }
}

