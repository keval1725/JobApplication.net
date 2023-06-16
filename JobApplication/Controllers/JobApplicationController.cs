using JobApplication.Data;
using JobApplication.Data.Models;
using JobApplication.Data.Models.Domain;
using JobApplication.Models.Domain;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;

namespace JobApplication.Controllers
{
    public class JobApplicationController : Controller
    {
        private readonly JobDbContext _JobDbContext;
        public JobApplicationController(JobDbContext jobDbContext)
        {
            _JobDbContext = jobDbContext;

        }
        [HttpGet]

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync("Mycookies");
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Registration registration)
        {

            await _JobDbContext.Registration.AddAsync(registration);

            await _JobDbContext.SaveChangesAsync();

            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Login(Registration registration)
        {
            var email = await _JobDbContext.Registration.Where(e => e.Email == registration.Email).FirstOrDefaultAsync();


            var Basic = await _JobDbContext.BasicDetailes.Where(e => e.UserId ==email.Id).ToListAsync();


            if (email != null)
            {
                if (email.Password == registration.Password)
                {
                    if (email.IsRole == 0)
                    {
                        var Clims = new List<Claim>()
                    {

                    new Claim(ClaimTypes.Name,email.User_Name),
                    new Claim(ClaimTypes.Role,"0"),
                    new Claim(ClaimTypes.Email,email.Email),
                    new Claim("user_ID",$"{email.Id }"),
                    new Claim("Users",$"{email.IsRole}"),

                    };
                        var identity = new ClaimsIdentity(Clims, "Mycookies");
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                        await HttpContext.SignInAsync("Mycookies", claimsPrincipal);

                        if (Basic.Count == 0)
                        {

                            return RedirectToAction("Index");
                        }
                        else
                        {
                            return RedirectToAction("UserList");
                        }

                    }
                    else
                    {
                        var Clims = new List<Claim>()
                    {

                    new Claim(ClaimTypes.Name,email.User_Name),
                    new Claim(ClaimTypes.Email,email.Email),
                    new Claim("user_ID",$"{email.Id }"),
                    new Claim("Admin",$"{email.IsRole}"),

                    };
                        var identity = new ClaimsIdentity(Clims, "Mycookies");
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                        await HttpContext.SignInAsync("Mycookies", claimsPrincipal);
                        return RedirectToAction("List");
                    }
                }
                else
                {
                    return RedirectToAction("Login");
                }
            }
            else
            {
                return RedirectToAction("Register");
            }



        }

        [Authorize]
        public IActionResult Index()
        {

            FormModel model = new FormModel();

            List<Education> educations = new List<Education>();

            Education education = new Education();
            educations.Add(education);

            List<WorkExperince> WorkExperince = new List<WorkExperince>() { new WorkExperince() };
            List<Langauge> Langauge = new List<Langauge>() { new Langauge() };
            List<Technologies> Technologies = new List<Technologies>() { new Technologies() };
            List<Prefrences> Prefrences = new List<Prefrences>() { new Prefrences() };
            List<Refrence> Refrence = new List<Refrence>() { new Refrence() };

            BasicDetailes Base = new BasicDetailes()
            {
                Educations = educations,
                WorkExperinces = WorkExperince,
                Langauges = Langauge,
                Technologiess = Technologies,
                Prefrencess = Prefrences,
                Refrences = Refrence
            };

            model.BasicDetailes = Base;

            IQueryable<OptionMaster> Gender = _JobDbContext.OptionMaster.Where(i => i.SelectMasterId == (_JobDbContext.SelectMaster.Where(i => i.MasterFieldName == "Gender").FirstOrDefault()!).SelectMasterId);
            model.Gender = Gender;

            IQueryable<OptionMaster> RelationShip = _JobDbContext.OptionMaster.Where(i => i.SelectMasterId == (_JobDbContext.SelectMaster.Where(i => i.MasterFieldName == "Relation").FirstOrDefault()!).SelectMasterId);
            model.RelationStatus = RelationShip;

            IQueryable<OptionMaster> EducationDetailes = _JobDbContext.OptionMaster.Where(i => i.SelectMasterId == (_JobDbContext.SelectMaster.Where(i => i.MasterFieldName == "CourseName").FirstOrDefault()!).SelectMasterId);
            model.EducationDetailes = EducationDetailes;

            IQueryable<OptionMaster> AllLangauges = _JobDbContext.OptionMaster.Where(i => i.SelectMasterId == (_JobDbContext.SelectMaster.Where(i => i.MasterFieldName == "Language").FirstOrDefault()!).SelectMasterId);
            model.AllLangauges = AllLangauges;

            IQueryable<OptionMaster> PreferdLocations = _JobDbContext.OptionMaster.Where(i => i.SelectMasterId == (_JobDbContext.SelectMaster.Where(i => i.MasterFieldName == "PreferedLocation").FirstOrDefault()!).SelectMasterId);
            model.PreferdLocations = PreferdLocations;

            IQueryable<OptionMaster> TechnologyName1 = _JobDbContext.OptionMaster.Where(i => i.SelectMasterId == (_JobDbContext.SelectMaster.Where(i => i.MasterFieldName == "Technology").FirstOrDefault()!).SelectMasterId);
            model.TechnologyNames = TechnologyName1;

            IQueryable<OptionMaster> Department = _JobDbContext.OptionMaster.Where(i => i.SelectMasterId == (_JobDbContext.SelectMaster.Where(i => i.MasterFieldName == "Department").FirstOrDefault()!).SelectMasterId);
            model.Departments = Department;


            return View(model);
        }
        [HttpPost]

        public async Task<IActionResult> Index(FormModel formModel)
        {

            BasicDetailes basicDetailes = new BasicDetailes();
            basicDetailes = formModel.BasicDetailes;

            List<Claim> ClaimList = User.Claims.ToList();
            foreach (var claim in ClaimList)
            {
                if (claim.Type == "user_ID")
                {
                    basicDetailes.UserId = Convert.ToInt32(((Claim)claim).Value);
                }


            }

            await _JobDbContext.BasicDetailes.AddAsync(basicDetailes);
            await _JobDbContext.SaveChangesAsync();

            if (basicDetailes.UserId == 1)
            {
                return RedirectToAction("List");
            }
            else
            {

                return RedirectToAction("UserList");

            }



        }

        [Authorize]
        [HttpGet]
    
        public async Task<IActionResult> Delete(int id)
        {
            int userid = 0;

            List<Claim> ClaimList = User.Claims.ToList();
            foreach (var claim in ClaimList)
            {
                if (claim.Type == "user_ID")
                {
                    userid = Convert.ToInt32(((Claim)claim).Value);
                }

            }
            //if (userid >1)
            //{

            //int basicid = await _JobDbContext.BasicDetailes.Where(e => e.UserId == userid).Select(e=>e.Basic_id).FirstOrDefaultAsync();

            //if (basicid == id )
            //{
            //    BasicDetailes basicDetailes = await _JobDbContext.BasicDetailes.Where(e => e.Basic_id == id).FirstOrDefaultAsync();
            //    basicDetailes.IsDeleted = 1;
            //   _JobDbContext.SaveChangesAsync();

            //    return RedirectToAction("UserList");
            //}
            //    return RedirectToAction("UserList");
            //}
            if (userid == 1)
            {
                BasicDetailes basicDetailes = await _JobDbContext.BasicDetailes.Where(e => e.Basic_id == id).FirstOrDefaultAsync();
                basicDetailes.IsDeleted = 1;
               await _JobDbContext.SaveChangesAsync();
                return RedirectToAction("List");
            }
            else
            {
                return RedirectToAction("AccessDenieds");
            }

        }
        [HttpGet]
        public IActionResult AccessDenieds()
        {
            return View();
        }


        [HttpGet]

        [Authorize(Policy = "Users")]
        public async Task<IActionResult> UserList()
        {
            var userid = 0;

            List<Claim> ClaimList = User.Claims.ToList();
            foreach (var claim in ClaimList)
            {
                if (claim.Type == "user_ID")
                {
                    userid = Convert.ToInt32(((Claim)claim).Value);

                }

            }
            if (userid != 0)
            {
                var user = await _JobDbContext.BasicDetailes.Where(i => i.UserId == userid).FirstOrDefaultAsync();
                BasicDetailes basicDetailes = new BasicDetailes();
                basicDetailes = user;
                return View(basicDetailes);

            }
            else
            {
                return View("AccessDenieds");
            }



        }

        [HttpGet]
        [Authorize(Policy = "adminonly")]
        public async Task<IActionResult> List(string serch, int page = 1, string columnorder = "Basic_id", string searchFor = "")
        {

            ListModel listModel = new ListModel();
         


            var sortingResult = from s in _JobDbContext.BasicDetailes.Where(i => i.IsDeleted == 0)
                                select s;
            int limit = 3;
            int CurrentPage = page;
            ViewBag.data = CurrentPage;

            int offset = limit * (CurrentPage - 1);
            ViewData["offset"] = offset + 1;
            ViewData["FirstNameSortParam"] = columnorder == "FIRST_NAME" ? "FirstName_desc" : "FIRST_NAME";
            ViewData["LastNameSortParam"] = columnorder == "LAST_NAME" ? "LastName_desc" : "LAST_NAME";
            ViewData["EmailSortParam"] = columnorder == "Email" ? "Email_desc" : "Email";
            ViewData["GenderNameSortParam"] = columnorder == "Gender" ? "Gender_desc" : "Gender";
            ViewData["CitySortParam"] = columnorder == "City" ? "City_desc" : "City";



            switch (columnorder)
            {
                case "FIRST_NAME":
                    sortingResult = sortingResult.OrderBy(x => x.FIRST_NAME);
                    break;

                case "FirstName_desc":
                    sortingResult = sortingResult.OrderByDescending(x => x.FIRST_NAME);
                    break;

                case "LastName_desc":
                    sortingResult = sortingResult.OrderByDescending(x => x.LAST_NAME);
                    break;

                case "LAST_NAME":
                    sortingResult = sortingResult.OrderBy(x => x.LAST_NAME);
                    break;

                case "Email_desc":
                    sortingResult = sortingResult.OrderByDescending(x => x.Email);
                    break;

                case "Email":
                    sortingResult = sortingResult.OrderBy(x => x.Email);
                    break;

                case "Gender_desc":
                    sortingResult = sortingResult.OrderByDescending(x => x.Gender);
                    break;

                case "Gender":
                    sortingResult = sortingResult.OrderBy(x => x.Gender);
                    break;

                case "City_desc":
                    sortingResult = sortingResult.OrderByDescending(x => x.City);
                    break;

                case "City":
                    sortingResult = sortingResult.OrderBy(x => x.City);
                    break;

                default:
                    sortingResult = sortingResult.OrderBy(x => x.Basic_id);
                    break;



            }


            if (!String.IsNullOrEmpty(serch))
            {
                sortingResult = sortingResult.Where(s => s.FIRST_NAME.Contains(serch)
                                           || s.LAST_NAME.Contains(serch) || s.Email.Contains(serch) || s.Gender.Contains(serch) || s.City.Contains(serch));

                ViewData["Search"] = serch;
            }
            else if (!String.IsNullOrEmpty(searchFor))
            {
                sortingResult = sortingResult.Where(s => s.FIRST_NAME.Contains(searchFor)
                                            || s.LAST_NAME.Contains(searchFor) || s.Email.Contains(searchFor) || s.Gender.Contains(searchFor) || s.City.Contains(searchFor));

                ViewData["Search"] = serch;
            }
     
            int countRows = sortingResult.ToList().Count();
            ViewData["TotalRows"] = countRows;

            sortingResult = sortingResult.Skip(offset).Take(limit);
            ViewData["CurrentSortOrder"] = columnorder;
            ViewData["CurrentPage"] = page;

            int TotalListData = offset + sortingResult.Count();

            if (countRows >= TotalListData) 
            {
                ViewData["TotalListData"] = TotalListData;
            }
            else
            {
                ViewData["TotalListData"] = TotalListData -limit;
            }

            int TotalPage = (int)Math.Ceiling(Convert.ToDouble(countRows) / Convert.ToDouble(limit));

            listModel.BasicDetailes = sortingResult.ToList();
            listModel.pagecount = TotalPage;




            if (!String.IsNullOrEmpty(serch))
            {
                return Json(new
                {
                    listModel,  
                    StartingLimit = ViewData["offset"],
                    EndingLimit = ViewData["TotalListData"],
                    TotalPages = ViewData["TotalRows"],
                    CurrentSortOrder = ViewData["CurrentSortOrder"],
                    CurrentPage = ViewData["CurrentPage"],
                    CurrentSearch = ViewData["Search"] ?? "",
                    FirstName = ViewData["FirstNameSortParam"],
                    LastName = ViewData["LastNameSortParam"],
                    EmailId = ViewData["EmailSortParam"],
                    Gender = ViewData["GenderNameSortParam"],
                    City = ViewData["CitySortParam"],

                });
            }
            else
            {
                return View(listModel);
            }






        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {


            var userid = 0;

            List<Claim> ClaimList = User.Claims.ToList();
            foreach (var claim in ClaimList)
            {
                if (claim.Type == "user_ID")
                {
                    userid = Convert.ToInt32(((Claim)claim).Value);

                }

            }
            int basic_id = await _JobDbContext.BasicDetailes.Where(i => i.UserId == userid).Select(i => i.Basic_id).FirstOrDefaultAsync();

            if (id == basic_id || userid == 1)
            {
                UpdateModel model = new UpdateModel();

                IQueryable<OptionMaster> Gender = _JobDbContext.OptionMaster.Where(i => i.SelectMasterId == (_JobDbContext.SelectMaster.Where(i => i.MasterFieldName == "Gender").FirstOrDefault()!).SelectMasterId);
                model.Gender = Gender;

                IQueryable<OptionMaster> RelationShip = _JobDbContext.OptionMaster.Where(i => i.SelectMasterId == (_JobDbContext.SelectMaster.Where(i => i.MasterFieldName == "Relation").FirstOrDefault()!).SelectMasterId);
                model.RelationStatus = RelationShip;

                IQueryable<OptionMaster> EducationDetailes = _JobDbContext.OptionMaster.Where(i => i.SelectMasterId == (_JobDbContext.SelectMaster.Where(i => i.MasterFieldName == "CourseName").FirstOrDefault()!).SelectMasterId);
                model.EducationDetailes = EducationDetailes;

                IQueryable<OptionMaster> AllLangauges = _JobDbContext.OptionMaster.Where(i => i.SelectMasterId == (_JobDbContext.SelectMaster.Where(i => i.MasterFieldName == "Language").FirstOrDefault()!).SelectMasterId);
                model.AllLangauges = AllLangauges;

                IQueryable<OptionMaster> PreferdLocations = _JobDbContext.OptionMaster.Where(i => i.SelectMasterId == (_JobDbContext.SelectMaster.Where(i => i.MasterFieldName == "PreferedLocation").FirstOrDefault()!).SelectMasterId);
                model.PreferdLocations = PreferdLocations;

                IQueryable<OptionMaster> TechnologyName1 = _JobDbContext.OptionMaster.Where(i => i.SelectMasterId == (_JobDbContext.SelectMaster.Where(i => i.MasterFieldName == "Technology").FirstOrDefault()!).SelectMasterId);
                model.TechnologyNames = TechnologyName1;

                IQueryable<OptionMaster> Department = _JobDbContext.OptionMaster.Where(i => i.SelectMasterId == (_JobDbContext.SelectMaster.Where(i => i.MasterFieldName == "Department").FirstOrDefault()!).SelectMasterId);
                model.Departments = Department;

                BasicDetailes basicDetailes = await _JobDbContext.BasicDetailes.Include(e => e.Educations)
                    .Include(e => e.WorkExperinces)
                     .Include(e => e.Langauges)
                     .Include(e => e.Technologiess)
                     .Include(e => e.Refrences)
                     .Include(e => e.Prefrencess)
                    .FirstOrDefaultAsync(e => e.Basic_id == id);


                model.BasicDetailes = basicDetailes;
                return View(model);
            }
            else
            {
                return RedirectToAction("AccessDenieds");
            }
   
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateModel updateModel)
           {

            var userid = 0;
            List<Claim> ClaimList = User.Claims.ToList();
            foreach (var claim in ClaimList)
            {
                if (claim.Type == "user_ID")
                {
                    userid = Convert.ToInt32(((Claim)claim).Value);

                }

            }


            if (userid == 1)
            {
                BasicDetailes basicDetailes = new BasicDetailes();


                for (int i = updateModel.BasicDetailes.Langauges.Count - 1; i >= 0; i--)
                {
                    if (updateModel.BasicDetailes.Langauges[i].langauge == null)
                    {
                        _JobDbContext.Langauges.Remove(updateModel.BasicDetailes.Langauges[i]);
                        updateModel.BasicDetailes.Technologiess.RemoveAt(i);
                    }
                }
                for (int i = updateModel.BasicDetailes.Technologiess.Count - 1; i >= 0; i--)
                {
                    if (updateModel.BasicDetailes.Technologiess[i].TechnologyName == null)
                    {
                        _JobDbContext.Technologies.Remove(updateModel.BasicDetailes.Technologiess[i]);
                        updateModel.BasicDetailes.Technologiess.RemoveAt(i);
                    }
                }
                basicDetailes = updateModel.BasicDetailes;

                _JobDbContext.BasicDetailes.Update(basicDetailes);
                await _JobDbContext.SaveChangesAsync();
                return RedirectToAction("List");
            }
            else if (userid > 1)
            {
                BasicDetailes basicDetailes = new BasicDetailes();


                for (int i = updateModel.BasicDetailes.Langauges.Count - 1; i >= 0; i--)
                {
                    if (updateModel.BasicDetailes.Langauges[i].langauge == null)
                    {
                        _JobDbContext.Langauges.Remove(updateModel.BasicDetailes.Langauges[i]);
                        updateModel.BasicDetailes.Technologiess.RemoveAt(i);
                    }
                }
                for (int i = updateModel.BasicDetailes.Technologiess.Count - 1; i >= 0; i--)
                {
                    if (updateModel.BasicDetailes.Technologiess[i].TechnologyName == null)
                    {
                        _JobDbContext.Technologies.Remove(updateModel.BasicDetailes.Technologiess[i]);
                        updateModel.BasicDetailes.Technologiess.RemoveAt(i);
                    }
                }
               
                basicDetailes = updateModel.BasicDetailes;

                _JobDbContext.BasicDetailes.Update(basicDetailes);
                await _JobDbContext.SaveChangesAsync();
                return RedirectToAction("UserList");
            }
            else
            {
                return RedirectToAction("AccessDenieds");
            }

        }
    }



}

