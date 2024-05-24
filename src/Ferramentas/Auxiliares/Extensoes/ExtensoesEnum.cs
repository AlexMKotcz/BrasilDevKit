using System.ComponentModel;
using System.Reflection;

namespace Ferramentas.Auxiliares.Extensoes;
public static class ExtensoesEnum
{
    public static string ObterDescricao<T>(this T valorEnum) where T : struct
    {
        Type tipo = valorEnum.GetType();
        if (!tipo.IsEnum)
        {
            throw new ArgumentException("O valorEnum deve ser do tipo Enum", nameof(valorEnum));
        }

        // Tenta encontrar um DescriptionAttribute para um possível nome amigável para o enum
        MemberInfo[] informaçõesMembro = tipo.GetMember(valorEnum.ToString() ?? "");
        if (informaçõesMembro != null && informaçõesMembro.Length > 0)
        {
            object[] atributos = informaçõesMembro[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (atributos != null && atributos.Length > 0)
            {
                // Extrai o valor da descrição
                return ((DescriptionAttribute)atributos[0]).Description;
            }
        }
        // Se não houver nenhum atributo de descrição, retorna apenas o ToString do enum
        return valorEnum.ToString() ?? "";
    }
}
