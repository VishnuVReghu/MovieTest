using HomeCinema.Data.Infrastructure;
using HomeCinema.Data.Repositories;
using HomeCinema.Entities;
using HomeCinema.Services;
using HomeCinema.Services.Utilities;
using HomeCinema.Web.Infrastructure.Core;
using HomeCinema.Web.Models;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;

namespace HomeCinema.Web.Controllers
{
    [Authorize(Roles="Admin")]
    [RoutePrefix("api/Account")]
    public class AccountController : ApiControllerBase
    {
        private readonly IMembershipService _membershipService;
        private readonly IEntityBaseRepository<Movie> _moviesRepository;

        public AccountController(IMembershipService membershipService,
            IEntityBaseRepository<Error> _errorsRepository, IUnitOfWork _unitOfWork, IEntityBaseRepository<Movie> moviesRepository)
            : base(_errorsRepository, _unitOfWork)
        {
            _membershipService = membershipService;
            _moviesRepository = moviesRepository;
        }

        //This is a comment
        [AllowAnonymous]
        [Route("authenticate")]
        [HttpPost]
        public HttpResponseMessage Login(HttpRequestMessage request, LoginViewModel user)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    MembershipContext _userContext = _membershipService.ValidateUser(user.Username, user.Password);
                    var userId = 1;
                    if (User.Identity.Name == WebConfigurationManager.AppSettings["User2"])
                    {
                        userId = 2;
                    }
                    var movies = _moviesRepository.GetAll().OrderByDescending(m => m.CreatedDate).Take(6).Where(x => x.UserId == userId).ToList();
                    user.TaskCount = movies.Count();
                    if (_userContext.User != null)
                    {
                        response = request.CreateResponse(HttpStatusCode.OK, new { success = true });
                    }
                    else
                    {
                        response = request.CreateResponse(HttpStatusCode.OK, new { success = false });
                    }

                    
                }
                else
                    response = request.CreateResponse(HttpStatusCode.OK, new { success = false });

                return response;
            });
        }
    }
}
