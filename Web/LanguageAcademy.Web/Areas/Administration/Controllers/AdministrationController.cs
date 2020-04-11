namespace LanguageAcademy.Web.Areas.Administration.Controllers
{
    using LanguageAcademy.Common;
    using LanguageAcademy.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
