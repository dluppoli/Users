using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using UsersAPI.Models;
using System.Data.Entity;
using UsersAPI.Dtos;
using AutoMapper;
using UsersAPI.App_Start;
using AutoMapper.QueryableExtensions;
using System.ComponentModel.DataAnnotations;
using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

namespace UsersAPI.Controllers
{
    [RoutePrefix("api/v1/users")]
    public class UsersController : ApiController
    {
        private MapperConfiguration mapperConfig;
        public UsersController() : base()
        {
            mapperConfig = new MapperConfiguration(
                c => c.AddProfile<DtoMappingProfile>()
            );
        }

        [HttpGet]
        public async Task<IHttpActionResult> Random()
        {
            using(var context = new UsersContext())
            {
                /*var user = await context.Users
                    .Include("Logins")
                    .FirstOrDefaultAsync();

                var userDto = new UserDto
                {
                    Id = user.Id,
                    LastName = user.LastName,
                    FirstName = user.FirstName,
                    Age = user.Age,
                    Address = user.Address,
                    BirthDate = user.BirthDate,
                    City = user.City,
                    PostalCode = user.PostalCode,
                    Email = user.Email,
                    Username = user.Username,
                    Password = user.Password,
                    Gender = user.Gender,
                    State = user.State,
                    Logins = user.Logins.ToList()
                };

                return userDto;*/



                /*return await context.Users.Select(user => new UserDto
                {
                    Id = user.Id,
                    LastName = user.LastName,
                    FirstName = user.FirstName,
                    Age = user.Age,
                    Address = user.Address,
                    BirthDate = user.BirthDate,
                    City = user.City,
                    PostalCode = user.PostalCode,
                    Email = user.Email,
                    Username = user.Username,
                    Password = user.Password,
                    Gender = user.Gender,
                    State = user.State,
                    Logins = user.Logins
                        .Select(s => new LoginDto
                        {
                            Id = s.Id,
                            UserId = s.UserId,
                            Date = s.Date,
                            LoginSuccessful = s.LoginSuccessful,
                            Note = s.Note
                        })
                        .ToList()
                }).FirstOrDefaultAsync();*/
                var mapperConfig = new MapperConfiguration(
                        c => c.AddProfile<DtoMappingProfile>()
                    );

                //var mapper = new Mapper(mapperConfig);
                //var user = await context.Users.FirstOrDefaultAsync();
                //return mapper.Map<UserDto>(user);

                var retval = await context.Users
                    .ProjectTo<UserDto>(mapperConfig)
                    .FirstOrDefaultAsync(q=>q.Id == -10);

                if (retval == null)
                    //throw new HttpResponseException(HttpStatusCode.NotFound);
                    //return Request.CreateResponse(HttpStatusCode.NotFound);
                    return NotFound();
                
                //return Request.CreateResponse(HttpStatusCode.OK, retval);
                return Ok(retval);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IHttpActionResult> GetOne(int id)
        {
            using (var context = new UsersContext())
            {
                var retval = await context.Users
                    .ProjectTo<UserDto>(mapperConfig)
                    .FirstOrDefaultAsync(q => q.Id == id);

                if (retval == null)
                    return NotFound();

                return Ok(retval);
            }
        }

        [Route("")]
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            using (var context = new UsersContext())
            {
                var retval = await context.Users
                    .ProjectTo<UserDto>(mapperConfig)
                    .ToListAsync();

                return Ok(retval);
            }
        }

        [HttpPost]
        [Route("")]
        public void Add([FromBody]UserDto nuovo)
        {
            var context = new ValidationContext(nuovo);
            var results = new List<ValidationResult>();
            var valid = Validator.TryValidateObject(nuovo, context, results,true);

            var mapper = new Mapper(mapperConfig);
            User user = mapper.Map<User>(nuovo);
        }
    }
}