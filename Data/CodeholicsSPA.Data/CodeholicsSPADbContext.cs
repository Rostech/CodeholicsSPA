﻿using CodeholicsSPA.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeholicsSPA.Data
{
    public class CodeholicsSPADbContext : IdentityDbContext<User>, ICodeholicsSPADbContext
    {
        public CodeholicsSPADbContext()
            : base("CodeholicsConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Friendship> Friendships { get; set; }

        public IDbSet<Message> Messages { get; set; }

        public IDbSet<Notification> Notifications { get; set; }

        public IDbSet<Project> Projects { get; set; }

        public IDbSet<Skill> Skills { get; set; }

        public IDbSet<Technology> Technologies { get; set; }

        public static CodeholicsSPADbContext Create()
        {
            return new CodeholicsSPADbContext();
        }
    }
}
