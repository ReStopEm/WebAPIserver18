namespace WebAPIworkers
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    /// <summary>
    /// Class-context for Database
    /// </summary>
    public class Factory : DbContext
    {
        /// <summary>
        /// Constructor method for DB conetext class
        /// </summary>
        public Factory()
         : base("name=Factory")
        {

        }
        /// <summary>
        /// table for Workers
        /// </summary>
         public virtual DbSet<Worker> Workers { get; set; }
    }
     /// <summary>
     /// Model class dor "Workers" entity
     /// </summary>
    public class Worker
    {
        /// <summary>
        /// primary key
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Workers first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Workers last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Workers age name
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Workers salary, decimal type 
        /// </summary>
        public decimal Salary { get; set; }

    }
}