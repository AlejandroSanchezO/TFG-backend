﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.Facility
{
    public class FacilityResult
    {
        public string Id { get; set; }

        public string NewId { get; set; }

        public string EOID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public DateTimeOffset ActiveFrom { get; set; }
    }
}
