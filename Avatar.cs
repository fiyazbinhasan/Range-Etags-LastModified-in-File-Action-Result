﻿using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace RangeEtagsLastModified
{
    public class Avatar
    {
        public Guid Id { get; set; }
        public byte[] File { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
