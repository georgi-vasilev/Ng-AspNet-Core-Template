﻿namespace AspNetCore_Angular_Template.Controllers.Base
{
    using Microsoft.AspNetCore.Mvc;

    [Route("[controller]")]
    [ApiController]
    public abstract class ApiController : ControllerBase
    {
    }
}

