﻿using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    class Base : Notifies

    {
        [Display(Name = "código")]

        public int Id { get; set; }

        [Display(Name = "Nome")]

        public string Nome { get; set; }

    }
}
