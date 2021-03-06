﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bargozideh.Framework.UnitOfWork;
using Dapper.FastCrud;

namespace Test.Domain
{
    [Table("MyWorld")]
    public class World : IEntity<int>
    {
        [Key]
        [DatabaseGeneratedDefaultValue]
        public int Id { get; set; }
        public string Guid { get; set; }
 
    }
}
