using System.Web;
using System.Web.Mvc;

namespace SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
