using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Purpose.Entities.Enums;

namespace EnumeratorDescription
{
    public static class EnumeratorExtension
    {
        public static string GetDescription(this Enum value)
        {
            // Obtém o tipo do Enum
            Type type = value.GetType();

            // Obtém o FieldInfo para o Emun
            System.Reflection.FieldInfo fieldInfo = type.GetField(value.ToString());

            // Obtém o atributo System.ComponentModel.Description do Enum
            System.ComponentModel.DescriptionAttribute[] attribs = fieldInfo.GetCustomAttributes(
                typeof(System.ComponentModel.DescriptionAttribute), false) as System.ComponentModel.DescriptionAttribute[];

            // Se encontrou o atributo, retorna a descrição, caso contrário retorna o GetName para ele, ou seja o ToString()
            return attribs.Length > 0 ? attribs[0].Description : System.Enum.GetName(type, value);
        }
    }
}
