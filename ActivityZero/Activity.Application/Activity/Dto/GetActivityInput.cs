﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace Activity.Activity.Dto
{
    class GetActivityInput:IInputDto
    {
        public int ActivityId { get; set; }
    }
}
